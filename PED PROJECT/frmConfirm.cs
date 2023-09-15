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
    public partial class frmConfirm : Form
    {
        private Form _formenviado;
        private Label _labelenviado;

        public frmConfirm(Form frmenviado, Label labelenviado)
        {
            InitializeComponent();
            _formenviado = frmenviado;
            _formenviado.Enabled = false;
            _labelenviado = labelenviado;
        }

        private void frmConfirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formenviado.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string texto1 = _labelenviado.Text;
            _labelenviado.Text = texto1 + "a";
            this.Close();
        }
    }
}
