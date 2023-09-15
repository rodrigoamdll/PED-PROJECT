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
    public partial class frmEditTask : Form
    {
        string nom = null;
        string apell = null;
        Task mitarea;

        public frmEditTask(string nombre, string apellido, Task mi_tarea)
        {
            InitializeComponent();
            nom = nombre;
            apell = apellido;
            mitarea = mi_tarea;
            dtphora.Value = DateTime.Now.Date + new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            frmTableEdit frm1 = new frmTableEdit(mitarea, nom, apell, txtdesc, cmbtipo, cmbestado, dtphora, label8);
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
            if (cmbestado.SelectedItem != null && cmbtipo.SelectedItem != null && txtdesc.Text != "")
            {
                if (cmbestado.SelectedItem.ToString()=="Finalizado")
                {
                    //Eliminamos de la base de datos
                    CnTarea objtarea1 = new CnTarea();
                    int oldinfo1 = objtarea1.Info(label8.Text);
                    objtarea1.Eliminar(oldinfo1);

                    string desc = txtdesc.Text;
                    string tipo1 = cmbtipo.SelectedItem.ToString();
                    DateTime h1 = dtphora.Value;
                    int hh = h1.Hour;
                    int mm = h1.Minute;

                    //Eliminamos del arbol
                    mitarea.Eliminar(oldinfo1, desc, tipo1, hh, mm);

                    frmMessage frm1 = new frmMessage(this);
                    this.Enabled = false;
                    frm1.label1.Text = "   Se modifico correctamente";
                    frm1.Width = 325;
                    frm1.picsi.Visible = true;
                    frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frm1.Show();

                    Limpiar();
                }
                else
                {
                    string descripcion = txtdesc.Text;
                    string tipo = cmbtipo.SelectedItem.ToString();
                    string estado = cmbestado.SelectedItem.ToString();
                    DateTime h = dtphora.Value;

                    string fullhm = h.ToString("HHmm");
                    string fullHM = h.ToString("hh:mm tt", CultureInfo.InvariantCulture);
                    label2.Text = fullHM;
                    int correlativo = Convert.ToInt32(fullhm);

                    CnTarea objtarea = new CnTarea();

                    int oldinfo = objtarea.Info(label8.Text);

                    objtarea.Modificar(nom, apell, oldinfo, dtphora, descripcion, tipo, estado);
                    mitarea.Actualizar(oldinfo, correlativo);

                    frmMessage frm1 = new frmMessage(this);
                    this.Enabled = false;
                    frm1.label1.Text = "   Se modifico correctamente";
                    frm1.Width = 325;
                    frm1.picsi.Visible = true;
                    frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frm1.Show();

                    Limpiar();
                }
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
