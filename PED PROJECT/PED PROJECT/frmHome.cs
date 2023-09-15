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
    public partial class frmHome : Form
    {
        public frmHome(string nombre)
        {
            InitializeComponent();
            label1.Text = "Buenos días, " + nombre;
        }
    }
}
