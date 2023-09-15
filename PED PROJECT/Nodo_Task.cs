using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PED_PROJECT
{
    public class Nodo_Task
    {
        // Campos
        Task arbol;
        public int info;
        public Nodo_Task Izquierdo;
        public Nodo_Task Derecho;
        public Nodo_Task Padre;
        public int altura;
        public int nivel;
        public string desc;
        public string tipo;
        public int hh;
        public int mm;

        private const int Radio = 50;
        private const int DistanciaH = 80;
        private const int DistanciaV = 10;
        private int CoordenadaX;
        private int CoordenadaY;

        public Task Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }

        public Nodo_Task(int nueva_info, string _desc, string _tipo, int _hh, int _mm, Nodo_Task izquierdo, Nodo_Task derecho, Nodo_Task padre)
        {
            info = nueva_info;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
            altura = 0;
            desc = _desc;
            tipo = _tipo;
            hh = _hh;
            mm = _mm;
        }

        //Verificar altura del árbol
        private static int Alturas(Nodo_Task t)
        {
            return t == null ? -1 : t.altura;
        }

        //función para insertar un nodo en el árbol
        public Nodo_Task Insertar(int x, string desc, string tipo, int hh, int mm, Nodo_Task t, int Level)
        {
            if (t == null)
            {
                t = new Nodo_Task(x,desc, tipo, hh, mm, null, null, null);
                t.nivel = Level;
            }
            else
            if (x < t.info)
            {
                Level++;
                t.Izquierdo = Insertar(x, desc, tipo, hh, mm, t.Izquierdo, Level);
            }
            else
            if (x > t.info)
            {
                Level++;
                t.Derecho = Insertar(x, desc, tipo, hh, mm, t.Derecho, Level);
            }
            else
            {
                MessageBox.Show("Dato ya existe en el Arbol", "Error de Ingreso");
            }
            return t;
        }

        //Función para eliminar un nodo de un árbol binario
        public void Eliminar(int x, ref Nodo_Task t)
        {
            if (t != null)
            {
                if (x < t.info)
                {
                    Eliminar(x, ref t.Izquierdo);
                }
                else
                {
                    if (x > t.info)
                    {
                        Eliminar(x, ref t.Derecho);
                    }
                    else
                    {
                        Nodo_Task NodoEliminar = t;
                        if (NodoEliminar.Derecho == null)
                        {
                            t = NodoEliminar.Izquierdo;
                        }
                        else
                        {
                            if (NodoEliminar.Izquierdo == null)
                            {
                                t = NodoEliminar.Derecho;
                            }
                            else
                            {
                                if (Alturas(t.Izquierdo) - Alturas(t.Derecho) > 0)
                                {
                                    Nodo_Task AuxiliarNodo = null;
                                    Nodo_Task Auxiliar = t.Izquierdo;
                                    bool bandera = false;

                                    while (Auxiliar.Derecho != null)
                                    {
                                        AuxiliarNodo = Auxiliar;
                                        Auxiliar = Auxiliar.Derecho;
                                        bandera = true;
                                    }

                                    t.info = Auxiliar.info;
                                    NodoEliminar = Auxiliar;

                                    if (bandera == true)
                                    {
                                        AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                                    }
                                    else
                                    {
                                        t.Izquierdo = Auxiliar.Izquierdo;
                                    }
                                }
                                else
                                {
                                    if (Alturas(t.Derecho) - Alturas(t.Izquierdo) > 0)
                                    {
                                        Nodo_Task AuxiliarNodo = null;
                                        Nodo_Task Auxiliar = t.Derecho;
                                        bool bandera = false;

                                        while (Auxiliar.Izquierdo != null)
                                        {
                                            AuxiliarNodo = Auxiliar;
                                            Auxiliar = Auxiliar.Izquierdo;
                                            bandera = true;
                                        }

                                        t.info = Auxiliar.info;
                                        NodoEliminar = Auxiliar;

                                        if (bandera == true)
                                        {
                                            AuxiliarNodo.Izquierdo = Auxiliar.Derecho;
                                        }
                                        else
                                        {
                                            t.Derecho = Auxiliar.Derecho;
                                        }
                                    }
                                    else
                                    {
                                        if (Alturas(t.Derecho) - Alturas(t.Izquierdo) == 0)
                                        {
                                            Nodo_Task AuxiliarNodo = null;
                                            Nodo_Task Auxiliar = t.Izquierdo;
                                            bool bandera = false;

                                            while (Auxiliar.Derecho != null)
                                            {
                                                AuxiliarNodo = Auxiliar;
                                                Auxiliar = Auxiliar.Derecho;
                                                bandera = true;
                                            }

                                            t.info = Auxiliar.info;
                                            NodoEliminar = Auxiliar;

                                            if (bandera == true)
                                            {
                                                AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                                            }
                                            else
                                            {
                                                t.Izquierdo = Auxiliar.Izquierdo;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo NO existe en el Arbol", "Error de eliminacion");
            }
        }

        public Nodo_Task Buscar(int x, Nodo_Task t)
        {
            if (t != null)
            {
                if (x == t.info)
                {
                    return t;
                }
                else
                {
                    if (x < t.info)
                    {
                        return (Buscar(x, t.Izquierdo));
                    }
                    else
                    {
                        if (x > t.info)
                        {
                            return (Buscar(x, t.Derecho));
                        }
                    }
                }
            }
            return null;
        }

        public enum TipRecorridoArbol
        {
            postor,
            inor,
            preor
        }

        public struct FormatoNodo
        {
            public Font fuente;
            public Brush relleno;
            public Brush rellenofuente;
            public Pen lapiz;
            public Brush encuentro;
        }

        public void DibujarRamas(Graphics grafo, FormatoNodo formatonodo)
        {
            if (Izquierdo != null)
            {
                grafo.DrawLine(formatonodo.lapiz, CoordenadaX, CoordenadaY, Izquierdo.CoordenadaX, Izquierdo.CoordenadaY);
                Izquierdo.DibujarRamas(grafo, formatonodo);
            }

            if (Derecho != null)
            {
                grafo.DrawLine(formatonodo.lapiz, CoordenadaX, CoordenadaY, Derecho.CoordenadaX, Derecho.CoordenadaY);
                Derecho.DibujarRamas(grafo, formatonodo);
            }
        }

        public void DibujarNodo(Graphics grafo, FormatoNodo formatonodo)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(formatonodo.encuentro, rect);
            grafo.FillEllipse(formatonodo.relleno, rect);
            grafo.DrawEllipse(formatonodo.lapiz, rect);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), formatonodo.fuente, formatonodo.rellenofuente, CoordenadaX, CoordenadaY, formato);

            if (Izquierdo != null)
            {
                Izquierdo.DibujarNodo(grafo, formatonodo);
            }


            if (Derecho != null)
            {
                Derecho.DibujarNodo(grafo, formatonodo);
            }
        }

        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);
            if (Izquierdo != null)
            {
                Izquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if (Derecho != null)
            {
                Derecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if (Izquierdo != null && Derecho != null)
            {
                CoordenadaX = (int)((Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2);
            }
            else
            {
                if (Izquierdo != null)
                {
                    aux1 = Izquierdo.CoordenadaX;
                    Izquierdo.CoordenadaX = CoordenadaX - 80;
                    CoordenadaX = aux1;
                }
                else
                {
                    if (Derecho != null)
                    {
                        aux2 = Derecho.CoordenadaX;
                        Derecho.CoordenadaX = CoordenadaX + 80;
                        CoordenadaX = aux2;
                    }
                    else
                    {
                        CoordenadaX = (int)(xmin + Radio / 2);
                        xmin += Radio;
                    }
                }
            }
        }
    }
}

