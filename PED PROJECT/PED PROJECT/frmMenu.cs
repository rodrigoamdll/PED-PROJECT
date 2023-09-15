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
    public partial class frmMenu : Form
    {
        Usuario miusuario3 = new Usuario();
        public Usuario user2;
        public frmMenu(string nom, string ape)
        {
            InitializeComponent();
            AbrirFormulario(new frmHome(nom));
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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmHome(user2.Nombre));
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAddTask(user2));
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmViewTask());
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEditTask());
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDeleteTask());
        }
    }
}
