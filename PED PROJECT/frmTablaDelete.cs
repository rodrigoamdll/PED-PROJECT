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
    public partial class frmTablaDelete : Form
    {
        string nombre = null;
        string apellido = null;
        private Guna.UI.WinForms.GunaLineTextBox _txtdesc;
        private Guna.UI.WinForms.GunaComboBox _cmbtipo;
        private Guna.UI.WinForms.GunaComboBox _cmbestado;
        private Guna.UI.WinForms.GunaDateTimePicker _dtphora;
        private Label _label10;
        Task _mitarea;

        public frmTablaDelete(Task mitarea, string nom, string apell, Label label10, Guna.UI.WinForms.GunaLineTextBox txtdesc, Guna.UI.WinForms.GunaComboBox cmbtipo, Guna.UI.WinForms.GunaComboBox cmbestado, Guna.UI.WinForms.GunaDateTimePicker dtphora)
        {
            InitializeComponent();
            nombre = nom;
            apellido = apell;
            _txtdesc = txtdesc;
            _cmbtipo = cmbtipo;
            _cmbestado = cmbestado;
            _dtphora = dtphora;
            _label10 = label10;
            _mitarea = mitarea;

            CnTarea objtarea = new CnTarea();
            string cod = objtarea.CodUsu(nombre, apellido);
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
                        reader.Read();
                        //act.Visible = true;
                        CnTarea cnTarea = new CnTarea();
                        cnTarea.MostrarC(tabladelete, nombre, apellido);
                    }
                    else
                    {
                        //noact.Visible = true;
                        //act.Visible = false;
                    }
                }
            }

        }

        private void tabladelete_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CnTarea objtarea = new CnTarea();
            string cod = objtarea.CodUsu(nombre, apellido);

            objtarea.Seleccionar(tabladelete, _txtdesc, _cmbtipo, _cmbestado, _dtphora);
            _label10.Text = tabladelete.CurrentRow.Cells[0].Value.ToString();

            int info = objtarea.Info(_txtdesc.Text);
            _mitarea.Buscar(info);
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
