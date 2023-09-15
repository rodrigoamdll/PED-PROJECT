using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static PED_PROJECT.Nodo_Task;

namespace PED_PROJECT
{
    public partial class frmArbol : Form
    {
        int Dato = 0;
        int cont = 0;
        Task mi_arbol;
        FormatoNodo formatonodo;
        Graphics g;
        public frmArbol(Task arbolaux, string nom)
        {
            InitializeComponent();
           
            mi_arbol = arbolaux;
            formatonodo.fuente = this.Font;
            formatonodo.relleno = Brushes.Blue;
            formatonodo.rellenofuente = Brushes.White;
            formatonodo.lapiz = Pens.Black;
            formatonodo.encuentro = Brushes.White;
            label1.Text = "Árbol de " + nom;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (mi_arbol!=null)
            {
                e.Graphics.Clear(this.BackColor);
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g = e.Graphics;

                mi_arbol.DibujarArbol(g, panel1.Size, formatonodo);
            }
        }

        private void frmArbol_Load(object sender, EventArgs e)
        {
            panel1.Refresh();           
        }
    }
}
