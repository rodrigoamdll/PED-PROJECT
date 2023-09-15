using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED_PROJECT
{
    public partial class frmAddTask : Form
    {
        Usuario user3 = new Usuario();
        Task mi_tarea;
        public frmAddTask(Usuario user2)
        {
            InitializeComponent();
            mi_tarea = new Task(null);
            user3 = user2;
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbtipo.SelectedItem.ToString();
            if (tipo== "Laborales")
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

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (desc.Text!="" || cmbtipo.SelectedIndex>=0)
            {
                string usu = user3.Usuarios;
                string descripcion = desc.Text;
                string tipo = cmbtipo.SelectedItem.ToString();
                DateTime h = hora.Value;
                int hh = h.Hour;
                int mm = h.Minute;

                string fullhm = hh.ToString() + "" + mm.ToString();
                int correlativo = Convert.ToInt32(fullhm);

                mi_tarea.Insertar(correlativo, descripcion, tipo, hh, mm);
                label4.Text = "La tarea es " + mi_tarea.Raiz.desc.ToString() + " , el tipo es " + mi_tarea.Raiz.tipo.ToString();

                frmMessage frm1 = new frmMessage(this);
                this.Enabled = false;
                frm1.label1.Text = "   Tarea Agregada!";
                frm1.picsi.Visible = true;
                frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm1.Show();
            }
            else
            {
                frmMessage frm1 = new frmMessage(this);
                this.Enabled = false;
                frm1.label1.Text = "¡Datos Incompletos!";
                frm1.picno.Visible = true;
                frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm1.Show();
            }
        }
    }
}
