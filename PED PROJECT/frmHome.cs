using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace PED_PROJECT
{
    public partial class frmHome : Form
    {
        string nom = null;
        string apell = null;
        Task mitarea;

        public frmHome(string nombre, string apellido, Task mi_tarea)
        {
            InitializeComponent();
            timer1.Start();

            nom = nombre;
            apell = apellido;
            mitarea = mi_tarea;

            DateTime now = DateTime.Now;
            int hour = now.Hour;

            if (hour >= 0 && hour < 12)
            {
                label1.Text = "Buenos días, " + nom;
                sunrise.BringToFront();
            }
            else if (hour >= 12 && hour < 18)
            {
                label1.Text = "Buenas tardes, " + nom;
                sun.BringToFront();
            }
            else if (hour >= 18 && hour < 24)
            {
                label1.Text = "Buenas noches, " + nom;
                moon.BringToFront();
            }

            CnTarea objtarea = new CnTarea();
            string cod = objtarea.CodUsu(nom, apell);
            Conexion cnx = new Conexion();

            string query = "SELECT TOP 3 Descripcion, Tipo, HoraProgramada FROM Tarea WHERE CodUsuario ='" + cod+ "' AND EstadoTarea = 'Activo' ORDER BY Info ASC;";
            using (SqlConnection connection = new SqlConnection(cnx.CadenaConexion()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        act.Visible = true;
                        noact.Visible = false;
                        CnTarea cnTarea = new CnTarea();
                        cnTarea.Mostrar(tablatareas, nom, apell);
                    }
                    else
                    {
                        noact.Visible = true;
                        act.Visible = false;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            // Convierte la hora a formato de 12 horas con AM/PM
            string time = now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
            // Actualiza el Label con la hora
            label4.Text = time;
            //label5.Text = time;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void pp3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Visualizar árbol", pp3);
        }

        private void pp3_Click(object sender, EventArgs e)
        {
            frmArbol frm1 = new frmArbol(mitarea, nom);         
            frm1.Show();
           
        }

        private void gunaButton1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Actualizar tabla", pp4);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            CnTarea objtarea = new CnTarea();
            string cod = objtarea.CodUsu(nom, apell);
            Conexion cnx = new Conexion();

            string query = "SELECT TOP 3 Descripcion, Tipo, HoraProgramada FROM Tarea WHERE CodUsuario ='" + cod + "' AND EstadoTarea = 'Activo' ORDER BY Info ASC;";
            using (SqlConnection connection = new SqlConnection(cnx.CadenaConexion()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        act.Visible = true;
                        noact.Visible = false;
                        CnTarea cnTarea = new CnTarea();
                        cnTarea.Mostrar(tablatareas, nom, apell);
                    }
                    else
                    {
                        noact.Visible = true;
                        act.Visible = false;
                    }
                }
            }
        }
    }
}
