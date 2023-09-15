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
    public partial class frmAddTask : Form
    {
        Usuario user3 = new Usuario();
        Task mitarea;
        string nom = null;
        string codusu = null;

        public frmAddTask(string nombre, string apellido, Task mi_tarea)
        {
            InitializeComponent();
            mitarea = mi_tarea;
            nom = nombre;
            hora.Value = DateTime.Now.Date + new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbtipo.SelectedIndex;
            if (index!=-1)
            {
                string tipo = cmbtipo.SelectedItem.ToString();
                if (tipo == "Laborales")
                {
                    pic1.Visible = true;
                    pic1.BringToFront();
                }
                if (tipo == "Acádemicas")
                {
                    pic2.Visible = true;
                    pic2.BringToFront();
                }
                if (tipo == "Del Hogar")
                {
                    pic3.Visible = true;
                    pic3.BringToFront();
                }
                if (tipo == "Cuidado Personal")
                {
                    pic4.Visible = true;
                    pic4.BringToFront();
                }
                if (tipo == "Ocio y Recreacion")
                {
                    pic5.Visible = true;
                    pic5.BringToFront();
                }
            }
        }

        public void Limpiar()
        {
            desc.Text = "";
            cmbtipo.SelectedIndex = -1;
            hora.Value = DateTime.Now;
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (desc.Text != "" || cmbtipo.SelectedIndex >= 0)
            {
                string usu = user3.Usuarios;
                string descripcion = desc.Text;
                string tipo = cmbtipo.SelectedItem.ToString();
                DateTime h = hora.Value;
                if (h > DateTime.Now)
                {
                    int hh = h.Hour;
                    int mm = h.Minute;

                    //string fullhm = hh.ToString() + "" + mm.ToString();
                    string fullhm = h.ToString("HHmm");
                    string fullHM = h.ToString("hh:mm tt", CultureInfo.InvariantCulture);
                    int correlativo = Convert.ToInt32(fullhm);

                    //Insertamos en el arbol
                    mitarea.Insertar(correlativo, descripcion, tipo, hh, mm);
                    label4.Text = "La tarea es " + mitarea.Raiz.desc.ToString() + " , el tipo es " + mitarea.Raiz.tipo.ToString();

                    //Agregamos a la base de datos
                    CnTarea objtarea = new CnTarea();
                    objtarea.Guardar(objtarea.Obtener(nom), correlativo, descripcion, tipo, fullHM, "Activo");
                    label4.Text = objtarea.Obtener(nom);

                    frmMessage frm1 = new frmMessage(this);
                    this.Enabled = false;
                    frm1.label1.Text = "   Tarea Agregada!";
                    frm1.picsi.Visible = true;
                    frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frm1.Show();

                    Limpiar();
                }
                else
                {
                    frmMessage frm1 = new frmMessage(this);
                    this.Enabled = false;
                    frm1.label1.Text = "Por favor seleccione valores futuros";
                    frm1.Width = 370;
                    frm1.picno.Visible = true;
                    frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frm1.Show();
                }
            }
            else
            {
                frmMessage frm1 = new frmMessage(this);
                this.Enabled = false;
                frm1.label1.Text = "¡Datos Incompletos!";
                frm1.Width = 247;
                frm1.picno.Visible = true;
                frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm1.Show();
            }
        }
    }
}
