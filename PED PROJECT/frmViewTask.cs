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

namespace PED_PROJECT
{
    public partial class frmViewTask : Form
    {
        string nom = null;
        string apell = null;
        Task mitarea;

        public frmViewTask(string nombre, string apellido, Task mi_tarea)
        {
            InitializeComponent();
            nom = nombre;
            apell = apellido;
            mitarea = mi_tarea;

            CnTarea objtarea = new CnTarea();
            string cod = objtarea.CodUsu(nom, apell);
            Conexion cnx = new Conexion();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbvista.SelectedItem.ToString()=="Por tipo")
            {
                label1.Visible = true;
                cmbcat.Visible = true;
            }
            else
            {
                label1.Visible = false;
                cmbcat.Visible = false;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (cmbvista.SelectedItem != null)
            {
                string tipo = cmbvista.SelectedItem.ToString();



                if (tipo != "")
                {
                    if (tipo == "Por tipo")
                    {
                        gbxtipo.BringToFront();
                        if (cmbcat.SelectedItem != null)
                        {
                            string cat = cmbcat.SelectedItem.ToString();

                            CnTarea objtarea = new CnTarea();
                            string cod = objtarea.CodUsu(nom, apell);
                            Conexion cnx = new Conexion();

                            string query = "SELECT * FROM Tarea WHERE CodUsuario ='" + cod + "';";
                            using (SqlConnection connection = new SqlConnection(cnx.CadenaConexion()))
                            {
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();

                                    if (reader.HasRows)
                                    {
                                        gbxtipo.Visible = true;
                                        gbxtipo.BringToFront();
                                        reader.Read();
                                        CnTarea cnTarea = new CnTarea();
                                        cnTarea.MostrarA(tablatipo, cat, nom, apell);
                                    }
                                    else
                                    {
                                        panel1.Visible = true;
                                        panel1.BringToFront();
                                        gbxprox.Visible = false;
                                        gbxtipo.Visible = false;
                                    }
                                }
                            }
                        }
                        else
                        {
                            frmMessage frm1 = new frmMessage(this);
                            this.Enabled = false;
                            frm1.label1.Text = "¡Seleccione una categoria!";
                            frm1.Width = 300;
                            frm1.picno.Visible = true;
                            frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                            frm1.Show();
                        }
                    }
                    else
                    {
                        CnTarea objtarea = new CnTarea();
                        string cod = objtarea.CodUsu(nom, apell);

                        Conexion cnx = new Conexion();
                        string query = "SELECT * FROM Tarea WHERE CodUsuario ='" + cod + "';";
                        using (SqlConnection connection = new SqlConnection(cnx.CadenaConexion()))
                        {
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                connection.Open();
                                SqlDataReader reader = command.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    gbxprox.Visible = true;
                                    gbxprox.BringToFront();
                                    reader.Read();
                                    CnTarea cnTarea = new CnTarea();
                                    cnTarea.MostrarB(tablaprox, nom, apell);
                                }
                                else
                                {
                                    panel1.Visible = true;
                                    panel1.BringToFront();
                                    gbxprox.Visible = false;
                                    gbxtipo.Visible = false;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                frmMessage frm1 = new frmMessage(this);
                this.Enabled = false;
                frm1.label1.Text = "¡Selecione un tipo de prioridad!";
                frm1.picno.Visible = true;
                frm1.Width = 340;
                frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm1.Show();
            }
        }
    }
}
