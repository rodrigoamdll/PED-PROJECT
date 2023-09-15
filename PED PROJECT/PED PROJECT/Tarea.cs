using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_PROJECT
{
    public class Tarea
    {
        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private int hora;
        public int Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        private int min;
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
    }
}
