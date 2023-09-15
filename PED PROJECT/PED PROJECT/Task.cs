using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static PED_PROJECT.Nodo_Task;

namespace PED_PROJECT
{
    public class Task
    {

        public Nodo_Task Raiz;
        public Task(Nodo_Task nueva_raiz)
        {
            Raiz = nueva_raiz;
        }

        public void Insertar(int x, string desc, string tipo, int hh, int mm)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Task(x, desc, tipo, hh, mm, null, null, null);
                Raiz.nivel = 0;
            }
            else
            {
                Raiz = Raiz.Insertar(x, desc, tipo, hh, mm, Raiz, Raiz.nivel);
            }
        }

        public void Eliminar(int x, string desc, string tipo, int hh, int mm)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Task(x, desc, tipo, hh, mm, null, null, null);
            }
            else
            {
                Raiz.Eliminar(x, ref Raiz);
            }
        }

        public void Buscar(int x)
        {
            if (Raiz != null)
            {
                Raiz.Buscar(x, Raiz);
            }
        }
    }
}