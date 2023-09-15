using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED_PROJECT
{
    public partial class frmMenu : Form
    {
        public Dictionary<string, Task> arbolesPorUsuario = new Dictionary<string, Task>();
        public void fMenu(string usuario ) 
        {
            Task arbolUsr=new Task(null);
            arbolesPorUsuario.Add("vea", arbolUsr );

        }
        Usuario miusuario3 = new Usuario();
        public Usuario user2;
        string nombre = null;
        string apellido = null;
        Task mi_tarea;
        
        private Timer timer;
        bool mensajevisto;
        public frmMenu() 
        {
        }
        public frmMenu(string nom, string ape,Task arboluser)
        {
            
            InitializeComponent();
            nombre = nom;
            apellido = ape;           
            mi_tarea = arboluser;
            AbrirFormulario(new frmHome(nombre, apellido, mi_tarea));
            //Creamos nuestro objeto de la clase arbol
            

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            mensajevisto = false;
            IniciarTemporizador();
        }

        private Form activeForm = null;
        private void AbrirFormulario(Form frmRecive)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = frmRecive;
            frmRecive.TopLevel = false;
            frmRecive.FormBorderStyle = FormBorderStyle.None;
            frmRecive.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmRecive);
            panelContenedor.Tag = frmRecive;
            frmRecive.BringToFront();
            frmRecive.Show();
        }

        public void Alertas(Color backcolor, Color color, string title, string text, Image icon)
        {
            Notificaciones frm2 = new Notificaciones();
            frm2.BackColor = backcolor;
            frm2.ColorAlertBox = color;
            frm2.TitleAlertBox = title;
            frm2.TextAlertBox = text;
            frm2.IconAlertBox = icon;
            frm2.ShowDialog();
        }

        // Manejador del evento Tick del temporizador
        private void Timer_Tick(object sender, EventArgs e)
        {
            CnTarea objtarea = new CnTarea();
            string cod = objtarea.CodUsu(nombre, apellido);


            TimeSpan horaactual = DateTime.Now.TimeOfDay;

            Conexion conexion = new Conexion();
            SqlConnection cn = conexion.EstablecerConexion();

            string query = "SELECT * FROM Tarea WHERE CodUsuario ='" + cod + "';";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string estado = reader["EstadoTarea"].ToString();
                int info = Convert.ToInt32(reader["Info"]);
                DateTime taskTime = DateTime.Parse(reader["HoraProgramada"].ToString());
                string tipo = reader["Tipo"].ToString();
                TimeSpan taskTimeOfDay = taskTime.TimeOfDay;

                TimeSpan timeDiff = taskTimeOfDay - horaactual;

                if (timeDiff <= TimeSpan.FromMinutes(1))
                {
                    if (mensajevisto != true && estado == "Activo")
                    {
                        mensajevisto = true;
                        // Mostrar mensaje de advertencia
                        string taskDescription = reader["Descripcion"].ToString();

                        //DialogResult r =
                        //MessageBox.Show("La tarea '" + taskDescription + "' debe ejecutarse en menos de 1 " +
                        //    "minutos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        switch(tipo)
                        {
                            case "Laborales":
                                Alertas(Color.LightBlue, Color.DodgerBlue, "Laborales", "La tarea " + taskDescription + " debe ejecutarse", Properties.Resources.work);
                                break;

                            case "Acádemicas":
                                Alertas(Color.FromArgb(192, 255, 192), Color.SeaGreen, "Acádemicas", "La tarea " + taskDescription + " debe ejecutarse", Properties.Resources.school);
                                break;
                            case "Del Hogar":
                                Alertas(Color.LightGoldenrodYellow, Color.Goldenrod, "Del Hogar", "La tarea " + taskDescription + " debe ejecutarse", Properties.Resources.home);
                                break;
                            case "Cuidado Personal":
                                Alertas(Color.LightPink, Color.DarkRed, "Cuidado Personal", "La tarea " + taskDescription + " debe ejecutarse", Properties.Resources.health);
                                break;
                            case "Ocio y Recreacion":
                                Alertas(Color.FromArgb(192, 192, 255), Color.BlueViolet, "Ocio y Recreacion", "La tarea " + taskDescription + " debe ejecutarse", Properties.Resources.games);
                                break;
                        }

                        mensajevisto = false;
                        //if (r == DialogResult.OK)
                        //{
                        //    mensajevisto = false;
                        //}

                        objtarea.ModificarEstado(nombre, apellido, "Pendiente", info);
                    }
                }
            }

            // Cerrar la conexión y liberar recursos
            reader.Close();
            conexion.CerrarConexion();
        }

        // Método para mostrar el mensaje de aviso
        private void MostrarMensajeAviso(Tarea tarea)
        {
            MessageBox.Show($"¡Es hora de hacer la tarea: {tarea.Nombre}!", "Aviso de tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para iniciar el temporizador
        public void IniciarTemporizador()
        {
            timer.Start();
        }

        // Método para detener el temporizador
        public void DetenerTemporizador()
        {
            timer.Stop();
        }


        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmHome(nombre, apellido, mi_tarea));
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAddTask(nombre, apellido, mi_tarea));
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmViewTask(nombre, apellido, mi_tarea));
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEditTask(nombre, apellido, mi_tarea));
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDeleteTask(nombre, apellido, mi_tarea));
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            frmLogin frm1 = new frmLogin();
            this.Hide();
            frm1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        public void CheckTask()
        {
        }

        private void gunaAdvenceButton1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Inicio", gunaAdvenceButton1);
        }

        private void gunaAdvenceButton2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Agregar Tareas", gunaAdvenceButton2);
        }

        private void gunaAdvenceButton3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Buscar Tareas", gunaAdvenceButton3);
        }

        private void gunaAdvenceButton4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Editar Tareas", gunaAdvenceButton4);
        }

        private void gunaAdvenceButton5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Eliminar Tareas", gunaAdvenceButton5);
        }

        private void gunaAdvenceButton6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Salir", gunaAdvenceButton6);
        }
    }
}
