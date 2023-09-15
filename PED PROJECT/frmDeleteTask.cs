using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmDeleteTask : Form
    {
        string nom = null;
        string apell = null;
        Task mitarea;

        public frmDeleteTask(string nombre, string apellido, Task mi_tarea)
        {
            InitializeComponent();
            nom = nombre;
            apell = apellido;
            mitarea = mi_tarea;
            dtphora.Value = DateTime.Now.Date + new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            //label6.Text = mitarea.ContarNodos().ToString();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            frmMessageDelete frmDeleteTask = new frmMessageDelete();
            frmDeleteTask.Show();
            this.Hide();
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            frmTablaDelete frm1 = new frmTablaDelete(mitarea, nom, apell,  label10, txtdesc, cmbtipo, cmbestado, dtphora);
            frm1.Show();
        }

        public void Limpiar()
        {
            txtdesc.Text = "";
            cmbtipo.SelectedIndex = -1;
            cmbestado.SelectedIndex = -1;
            dtphora.Value = DateTime.Now;
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (cmbestado.SelectedIndex!=-1 && cmbtipo.SelectedIndex!=-1 && txtdesc.Text!="")
            {
                frmConfirm frm2 = new frmConfirm(this, label4);
                this.Enabled = false;
                frm2.label1.Text = "¿Esta seguro de eliminar el registro?";
                frm2.Width = 340;
                frm2.pictureBox1.Width = 340;
                frm2.button2.Visible = true;
                frm2.button4.Visible = true;
                frm2.picwhy.Visible = true;
                frm2.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm2.Show();
            }
            else
            {
                frmMessage frm1 = new frmMessage(this);
                this.Enabled = false;
                frm1.label1.Text = "¡Campos incompletos!";
                frm1.Width = 270;
                frm1.picno.Visible = true;
                frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm1.Show();
            }    
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            //Eliminamos de la base de datos
            CnTarea objtarea = new CnTarea();
            int oldinfo = objtarea.Info(label10.Text);
            objtarea.Eliminar(oldinfo);

            string desc = txtdesc.Text;
            string tipo = cmbtipo.SelectedItem.ToString();
            DateTime h = dtphora.Value;
            int hh = h.Hour;
            int mm = h.Minute;

            //Eliminamos del arbol
            mitarea.Eliminar(oldinfo, desc, tipo, hh, mm);

            frmMessage frm1 = new frmMessage(this);
            this.Enabled = false;
            frm1.label1.Text = "   Se elimino correctamente";
            frm1.Width = 325;
            frm1.picsi.Visible = true;
            frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm1.Show();

            Limpiar();
        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
