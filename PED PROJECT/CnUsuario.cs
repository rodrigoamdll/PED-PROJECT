using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PED_PROJECT
{
    class CnUsuario
    {
        public void Mostrar(DataGridView tabla)
        {
            Conexion objconexion = new Conexion();
            try
            {
                tabla.DataSource = null;

                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Usuario;", objconexion.EstablecerConexion());

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                tabla.DataSource = dt;

                objconexion.CerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
            }
        }

        public void Guardar(string nom, string apell, string contra, string usu)
        {
            Conexion objconexion = new Conexion();
            try
            {
                string query = "INSERT INTO Usuario(CodUsuario, Nombre, Apellido, Contrasena)"
                    + "VALUES('" + usu + "','" + nom + "','" + apell + "','" + contra + "');";

                SqlCommand micomando = new SqlCommand(query, objconexion.EstablecerConexion());
                SqlDataReader mireader;
                mireader = micomando.ExecuteReader();

                while(mireader.Read())
                {

                }
                //MessageBox.Show("Se guardo correctamente");

                objconexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
            }
        }

        public void Seleccionar(DataGridView tabla, TextBox nom, TextBox apell, TextBox contra)
        {
            try
            {
                nom.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                apell.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                contra.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se logro seleccionar los registros, error: " + ex.ToString());
            }
        }

        public void Modificar(string nom, string apell, string contra, string usu)
        {
            Conexion objconexion = new Conexion();
            try
            {
                string query = "UPDATE Usuario SET Usuario.Nombre='" + nom +
                    "', Usuario.Apellido='" + apell + "', Usuario.Contrasena='" + contra +
                    "' WHERE Usuario.CodUsuario='" + usu+"';";


                SqlCommand micomando = new SqlCommand(query, objconexion.EstablecerConexion());
                SqlDataReader mireader;
                mireader = micomando.ExecuteReader();

                while (mireader.Read())
                {

                }
                MessageBox.Show("Se modifico correctamente");

                objconexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar los registros, error: " + ex.ToString());
            }
        }

        public void Eliminar(string usu)
        {
            Conexion objconexion = new Conexion();
            try
            {
                string query = "DELETE FROM Usuario WHERE Usuario.CodUsuario='" + usu + "';";


                SqlCommand micomando = new SqlCommand(query, objconexion.EstablecerConexion());
                SqlDataReader mireader;
                mireader = micomando.ExecuteReader();

                while (mireader.Read())
                {

                }
                MessageBox.Show("Se elimino correctamente");

                objconexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro eliminar los registros, error: " + ex.ToString());
            }
        }
    }
}
