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
    public partial class frmAddUser : Form
    {
        Usuario miusuario1 = new Usuario();
        public Usuario user2;
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            frmLogin frm1 = new frmLogin();
            frm1.Show();
            this.Hide();
        }

        private void gunaButton5_Click_1(object sender, EventArgs e)
        {
            frmLogin frm1 = new frmLogin();
            if (txtnom.Text == "" || txtapell.Text == "" || txtpass.Text == "" || gunaCheckBox1.Checked==false)
            {
                frm1.user1 = user2;
                frm1.Show();
                this.Hide();
            }
            else
            {
                frm1.user1 = miusuario1;
                frm1.Show();
                this.Hide();
            }
        }

        private void frmAddUser_Activated(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void gunaTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtnom.Text == "Nombre")
            {
                txtnom.Text = "";
            }
        }

        private void gunaTextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtapell.Text == "Apellido")
            {
                txtapell.Text = "";
            }
        }

        private void gunaTextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (txtnom.Text==""||txtapell.Text==""||txtpass.Text==""||gunaCheckBox1.Checked==false)
            {
                frmMessage frm1 = new frmMessage(this);
                this.Enabled = false;
                frm1.label1.Text = "¡Datos Incompletos!";
                frm1.picno.Visible = true;
                frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm1.Show();
            }
            else
            {
                string nom = txtnom.Text;
                string apell = txtapell.Text;
                string usu = nom.ToLower() + "." + apell.ToLower();
                string pass = txtpass.Text;
                txtusu.Text = usu;
                txtusu.Visible = true;

                frmMessage frm1 = new frmMessage(this);
                this.Enabled = false;
                frm1.label1.Text = "Usuario Registrado";
                frm1.picsi.Visible = true;
                frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm1.Show();

                miusuario1.Nombre = nom;
                miusuario1.Apellido = apell;
                miusuario1.Usuarios = usu;
                miusuario1.Contraseña = pass;
            }
        }
    }
}
