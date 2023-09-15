using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_PROJECT
{
    public class Usuario
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string usuario;
        public string Usuarios
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private string contraseña;
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
    }
}
