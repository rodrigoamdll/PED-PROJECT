using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PED_PROJECT
{
    class Conexion
    {
        SqlConnection cn = new SqlConnection();

        static string servidor="localhost";
        static string bd="DailyTask";
        static string usuario="sa";
        static string password="12345";
        //static string puerto= "1433";

        string cadenaconexion = "Data Source=" + servidor + /*"," + puerto +*/ ";" + "user id=" + usuario +
            ";" + "password=" + password +";"+ "Initial Catalog=" + bd + ";" + "Persist Security Info=true";

        public SqlConnection EstablecerConexion()
        {
            try 
            {
                cn.ConnectionString = cadenaconexion;
                cn.Open();
                //MessageBox.Show("Se conecto correctamente a la base de datos");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logro conectar a la base de datos" + e.ToString());
            }

            return cn;
        }

        public string CadenaConexion()
        {
            return cadenaconexion;
        }
        public void CerrarConexion()
        {
            cn.Close();
        }
    }
}
