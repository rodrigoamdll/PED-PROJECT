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

        private int totalNodos = 0;
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

        public void Actualizar(int valorBusqueda, int nuevoValor)
        {
            Raiz = ActualizarNodo(Raiz, valorBusqueda, nuevoValor);
        }

        private Nodo_Task ActualizarNodo(Nodo_Task nodoActual, int valorBusqueda, int nuevoValor)
        {
            if (nodoActual == null)
            {
                return null;
            }

            if (valorBusqueda == nodoActual.info)
            {
                nodoActual.info = nuevoValor;
            }
            else if (valorBusqueda < nodoActual.info)
            {
                nodoActual.Izquierdo = ActualizarNodo(nodoActual.Izquierdo, valorBusqueda, nuevoValor);
            }
            else
            {
                nodoActual.Derecho = ActualizarNodo(nodoActual.Derecho, valorBusqueda, nuevoValor);
            }

            return nodoActual;
        }


        public void Buscar(int x)
        {
            if (Raiz != null)
            {
                Raiz.Buscar(x, Raiz);
            }
        }

        public int ContarNodos()
        {
            return totalNodos;
        }

        public void DibujarArbol(Graphics grafo, Size areadibujo, FormatoNodo formatonodo)
        {
            int x, y;
            x = areadibujo.Width / 2;
            y = 40;
            if (Raiz == null)
            {
                return;
            }
            Raiz.PosicionNodo(ref x, y);
            Raiz.DibujarRamas(grafo, formatonodo);
            Raiz.DibujarNodo(grafo, formatonodo);
        }

        //public int ContarNodos(Nodo_Task rootNode = null)
        //{
        //    if (rootNode == null) rootNode = Raiz;
        //    int count = 1; // Contar el nodo raíz
        //    if (rootNode.Izquierdo != null)
        //    {
        //        count += ContarNodos(rootNode.Izquierdo); // Recursivamente contar los nodos hijos izquierdos
        //    }
        //    if (rootNode.Derecho != null)
        //    {
        //        count += ContarNodos(rootNode.Derecho); // Recursivamente contar los nodos hijos derechos
        //    }
        //    return count;
        //}

    }
}