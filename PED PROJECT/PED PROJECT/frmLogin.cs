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
    public partial class frmLogin : Form
    {
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
            if (user1 is null)
            {
                if (txtcod.Text == "" || txtcod.Text == "Usuario" || txtcontra.Text == "" || txtcontra.Text == "Contraseña")
                {
                    frmMessage frm2 = new frmMessage(this);
                    this.Enabled = false;
                    frm2.label1.Text = "¡Datos Incompletos!";
                    frm2.picno.Visible = true;
                    frm2.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frm2.Show();
                }
                else
                {
                    frmMessage frm2 = new frmMessage(this);
                    this.Enabled = false;
                    frm2.label1.Text = "¡Credenciales Incorrectas!";
                    frm2.Width = 280;
                    frm2.picno.Visible = true;
                    frm2.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frm2.Show();
                }
            }
            else
            {
                miusuario2 = user1;
                string nom = miusuario2.Nombre;
                string ape = miusuario2.Apellido;
                if (txtcod.Text == "" || txtcontra.Text == "")
                {
                    frmMessage frm2 = new frmMessage(this);
                    this.Enabled = false;
                    frm2.label1.Text = "¡Datos Incompletos!";
                    frm2.picno.Visible = true;
                    frm2.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frm2.Show();
                }
                else
                {
                    if (txtcod.Text == miusuario2.Usuarios)
                    {
                        if (txtcontra.Text == miusuario2.Contraseña)
                        {
                            this.Hide();
                            frmWelcome frm2 = new frmWelcome(nom, ape);
                            frm2.ShowDialog();

                            frmMenu frm3 = new frmMenu(nom, ape);
                            frm3.Show();
                            frm3.user2 = miusuario2;
                        }
                        else
                        {
                            frmMessage frm2 = new frmMessage(this);
                            this.Enabled = false;
                            frm2.label1.Text = "¡Contraseña incorrecta!";
                            frm2.Width = 255;
                            frm2.picno.Visible = true;
                            frm2.FormBorderStyle = FormBorderStyle.FixedSingle;
                            frm2.Show();
                        }

                    }
                    else
                    {
                        frmMessage frm2 = new frmMessage(this);
                        this.Enabled = false;
                        frm2.label1.Text = "¡Usuario incorrecto!";
                        frm2.picno.Visible = true;
                        frm2.FormBorderStyle = FormBorderStyle.FixedSingle;
                        frm2.Show();
                    }
                }
            }
        }
    }
}
