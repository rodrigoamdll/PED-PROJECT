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

namespace PED_PROJECT
{
    public partial class frmLogin : Form
    {
        public Dictionary<string, Task> arbolesPorUsuario = new Dictionary<string, Task>();
        Usuario miusuario2 = new Usuario();
        public Usuario user1;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void gunaTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtcod.Text == "Usuario")
            {
                txtcod.Text = "";
            }
        }

        private void gunaTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtcontra.Text == "Contraseña")
            {
                txtcontra.Text = "";
                txtcontra.PasswordChar = '•';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUser frm1 = new frmAddUser();
            frm1.user2 = user1;
            frm1.Show();
            this.Hide();
        }

        private void viewsi_Click(object sender, EventArgs e)
        {
            viewno.BringToFront();
            txtcontra.PasswordChar = '•';
        }

        private void viewno_Click(object sender, EventArgs e)
        {
            viewsi.BringToFront();
            txtcontra.PasswordChar = '\0';
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

            Conexion cnx = new Conexion();
            string query = "SELECT COUNT(*) FROM Usuario WHERE CodUsuario=@CodUsuario AND Contrasena=@Contrasena";
            using (SqlConnection connection = new SqlConnection(cnx.CadenaConexion()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CodUsuario", txtcod.Text);
                    command.Parameters.AddWithValue("@Contrasena", txtcontra.Text);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        query = "SELECT Nombre, Apellido FROM Usuario WHERE CodUsuario=@CodUsuario";
                        command.CommandText = query;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string nombre = reader.GetString(0);
                            string apellido = reader.GetString(1);

                            this.Hide();
                            frmWelcome frm2 = new frmWelcome(nombre, apellido);
                            frm2.ShowDialog();
                            if (ArbolesUsuarios.Diccionario.ContainsKey(txtcod.Text.ToLower()))
                            {
                                frmMenu frm3 = new frmMenu(nombre, apellido, ArbolesUsuarios.Diccionario[txtcod.Text.ToLower()]);
                                frm3.Show();
                                frm3.user2 = miusuario2;
                            }
                            else 
                            {
                                CnTarea frm4 = new CnTarea();
                                Task arbolUsr = new Task(null);
                                frm4.regArboles(txtcod.Text.ToLower(),arbolUsr);
                                frmMenu frm3 = new frmMenu(nombre, apellido, ArbolesUsuarios.Diccionario[txtcod.Text.ToLower()]);
                                frm3.Show();
                                frm3.user2 = miusuario2;

                            }                                           
                        }
                    }
                    else
                    {
                        frmMessage frm2 = new frmMessage(this);
                        this.Enabled = false;
                        frm2.label1.Text = "¡Credenciales incorrectas!";
                        frm2.Width = 255;
                        frm2.picno.Visible = true;
                        frm2.FormBorderStyle = FormBorderStyle.FixedSingle;
                        frm2.Show();
                    }
                }
            }

        }
    }
}
