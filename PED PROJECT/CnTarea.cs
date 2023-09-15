using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace PED_PROJECT
{
    class CnTarea
    {
        public void regArboles(string usu,Task arbolUsu)
        {
            ArbolesUsuarios.Diccionario.Add(usu.ToLower(), arbolUsu);
            Conexion conec = new Conexion();
            //conec.EstablecerConexion();
            string cadena = "SELECT Info,Descripcion, Tipo, HoraProgramada,EstadoTarea FROM Tarea WHERE CodUsuario like '" + usu + "' and (EstadoTarea like 'Activo' or EstadoTarea like 'Pendiente') order By  id ASC";
            string query = "SELECT COUNT(*)  FROM Tarea WHERE CodUsuario like '" + usu + "' and (EstadoTarea like 'Activo' or EstadoTarea like 'Pendiente')";
            SqlCommand cont = new SqlCommand(query,conec.EstablecerConexion());
            int count=(int)cont.ExecuteScalar();
            conec.CerrarConexion();
            
            if (count > 0)
            {
                // conec.EstablecerConexion();
                SqlCommand comando = new SqlCommand(cadena, conec.EstablecerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int Info = reader.GetInt32(0);
                    string desc = reader.GetString(1);
                    string Tipo = reader.GetString(2);
                    //String Horaprogramada=reader.GetString(3);
                    string full = Info.ToString();
                    int L = full.Length;
                    string fullh;
                    string fullm;
                    if (L == 4)
                    {
                        fullh = full[0].ToString() + full[1].ToString();
                        fullm = full[2].ToString() + full[3].ToString();
                        int hh = Convert.ToInt32(fullh);
                        int mm = Convert.ToInt32(fullm);
                        ArbolesUsuarios.Diccionario[usu.ToLower()].Insertar(Info, desc, Tipo, hh, mm);

                    }
                    else if (L == 3)
                    {
                        fullh = full[L - 3].ToString();
                        fullm = full[L - 2].ToString() + full[L - 1].ToString();
                        int hh = Convert.ToInt32(fullh);
                        int mm = Convert.ToInt32(fullm);
                        ArbolesUsuarios.Diccionario[usu.ToLower()].Insertar(Info, desc, Tipo, hh, mm);
                    }
                    else if (L == 2)
                    {
                        fullh = "0";
                        fullm = full[L - 2].ToString() + full[L - 1].ToString();
                        int hh = Convert.ToInt32(fullh);
                        int mm = Convert.ToInt32(fullm);
                        ArbolesUsuarios.Diccionario[usu.ToLower()].Insertar(Info, desc, Tipo, hh, mm);
                    }
                    else if (L == 1)
                    {
                        fullh = "0";
                        fullm = full[L - 1].ToString();
                        int hh = Convert.ToInt32(fullh);
                        int mm = Convert.ToInt32(fullm);
                        ArbolesUsuarios.Diccionario[usu.ToLower()].Insertar(Info, desc, Tipo, hh, mm);
                    }
                    else if (L == 0)
                    {
                        fullh = "0";
                        fullm = "0";
                        int hh = Convert.ToInt32(fullh);
                        int mm = Convert.ToInt32(fullm);
                        ArbolesUsuarios.Diccionario[usu.ToLower()].Insertar(Info, desc, Tipo, hh, mm);
                    }
                    
                }


            }
            else
            {
                conec.CerrarConexion();
            }

        }
        public string CodUsu(string usu, string apell)
        {
            Conexion objconexion = new Conexion();
            try
            {
                string consultaSql = "SELECT CodUsuario FROM Usuario WHERE Nombre = @nombreUsuario AND Apellido= @apellidoUsuario";

                SqlConnection conexion = new SqlConnection(objconexion.CadenaConexion());

                SqlCommand comando = new SqlCommand(consultaSql, conexion);

                comando.Parameters.AddWithValue("@nombreUsuario", usu);
                comando.Parameters.AddWithValue("@apellidoUsuario", apell);

                conexion.Open();
                string codigoUsuario = (string)comando.ExecuteScalar();
                conexion.Close();

                return codigoUsuario; // Agregamos el return para devolver el código de usuario

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
                return ""; // Devolvemos un string vacío en caso de error
            }
        }


        public int Info(string desc)
        {
            Conexion objconexion = new Conexion();
            try
            {
                string consultaSql = "SELECT Info FROM Tarea WHERE Descripcion = @Descripcion";

                SqlConnection conexion = new SqlConnection(objconexion.CadenaConexion());

                SqlCommand comando = new SqlCommand(consultaSql, conexion);

                comando.Parameters.AddWithValue("@Descripcion", desc);

                conexion.Open();
                int Info = (int)comando.ExecuteScalar();
                conexion.Close();

                return Info; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
                return 0; 
            }
        }

        public string Obtener(string nom)
        {
            string codigoUsuario = "";

            Conexion cnx = new Conexion();
            using (SqlConnection connection = new SqlConnection(cnx.CadenaConexion()))
            {
                // Abrir la conexión
                connection.Open();

                // Consultar el código del usuario por su nombre
                string query = "SELECT CodUsuario FROM Usuario WHERE Nombre = @nombre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añadir parámetro para el nombre del usuario
                    command.Parameters.AddWithValue("@nombre", nom);

                    // Ejecutar la consulta y obtener el código del usuario
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            codigoUsuario = reader.GetString(0);
                        }
                    }
                }
            }
            return codigoUsuario;
        }

        public void Mostrar(DataGridView tabla, string nom, string apell)
        {
            string cod = CodUsu(nom, apell);
            Conexion objconexion = new Conexion();
            try
            {
                tabla.DataSource = null;

                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT TOP 3 Descripcion, Tipo, HoraProgramada FROM Tarea WHERE CodUsuario = @CodigoUsuario AND EstadoTarea = 'Activo' ORDER BY Info ASC;", objconexion.EstablecerConexion());

                adaptador.SelectCommand.Parameters.AddWithValue("@CodigoUsuario", cod);

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                tabla.DataSource = dt;

                objconexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
            }
        }

        public void MostrarA(DataGridView tabla, string tipo, string nom, string apell)
        {
            string cod = CodUsu(nom, apell);
            Conexion objconexion = new Conexion();
            try
            {
                tabla.DataSource = null;

                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT Descripcion, Tipo, HoraProgramada, EstadoTarea FROM Tarea WHERE Tipo = @parametro AND CodUsuario = @CodigoUsuario;", objconexion.EstablecerConexion());
                adaptador.SelectCommand.Parameters.AddWithValue("@parametro", tipo);
                adaptador.SelectCommand.Parameters.AddWithValue("@CodigoUsuario", cod);

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                tabla.DataSource = dt;

                objconexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
            }
        }

        public void MostrarB(DataGridView tabla, string nom, string apell)
        {
            string cod = CodUsu(nom, apell);
            Conexion objconexion = new Conexion();
            try
            {
                tabla.DataSource = null;

                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT Descripcion, Tipo, HoraProgramada, EstadoTarea FROM Tarea WHERE CodUsuario = @CodigoUsuario ORDER BY Info ASC", objconexion.EstablecerConexion());
                adaptador.SelectCommand.Parameters.AddWithValue("@CodigoUsuario", cod);

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                tabla.DataSource = dt;

                objconexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
            }
        }

        public void MostrarC(DataGridView tabla, string nom, string apell)
        {
            string cod = CodUsu(nom, apell);
            Conexion objconexion = new Conexion();
            try
            {
                tabla.DataSource = null;

                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT Descripcion, Tipo, HoraProgramada, EstadoTarea FROM Tarea WHERE CodUsuario = @CodigoUsuario", objconexion.EstablecerConexion());
                adaptador.SelectCommand.Parameters.AddWithValue("@CodigoUsuario", cod);

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                tabla.DataSource = dt;

                objconexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
            }
        }


        public void Guardar(string usu, int info, string desc, string tipo, string hora, string estado)
        {
            Conexion objconexion = new Conexion();

            try
            {
                string query = "INSERT INTO Tarea(CodUsuario, Info, Descripcion, Tipo, HoraProgramada, EstadoTarea)"
                    + "VALUES('" + usu + "','" + info + "','" + desc + "','" + tipo + "','"+hora+"','"+estado+ "');";

                SqlCommand micomando = new SqlCommand(query, objconexion.EstablecerConexion());
                SqlDataReader mireader;
                mireader = micomando.ExecuteReader();

                while (mireader.Read())
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

        //private Guna.UI.WinForms.GunaLineTextBox _txtdesc;
        //private Guna.UI.WinForms.GunaComboBox _cmbtipo;
        //private Guna.UI.WinForms.GunaComboBox _cmbestado;
        //private Guna.UI.WinForms.GunaDateTimePicker _dtphora;
        public void Seleccionar(DataGridView tabla, Guna.UI.WinForms.GunaLineTextBox desc, ComboBox tipo, ComboBox estado, Guna.UI.WinForms.GunaDateTimePicker hora)
        {
            try
            {
                desc.Text = tabla.CurrentRow.Cells[0].Value.ToString();
                tipo.Text = tabla.CurrentRow.Cells[1].Value.ToString();

                hora.Format = DateTimePickerFormat.Custom;
                hora.CustomFormat = "HH:mm:ss";

                string horaString = tabla.CurrentRow.Cells[2].Value.ToString();
                DateTime h = DateTime.ParseExact(horaString, "h:mm tt", CultureInfo.InvariantCulture);
                hora.Value = h;


                estado.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro seleccionar los registros, error: " + ex.ToString());
            }
        }

        public void Modificar(string nom, string apell, int oldinfo, Guna.UI.WinForms.GunaDateTimePicker dtphora, string desc, string tipo, string estado)
        {
            Conexion objconexion = new Conexion();

            DateTime h = dtphora.Value;
            string fullhm = h.ToString("HHmm");
            string fullHM = h.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            int correlativo = Convert.ToInt32(fullhm);

            string cod = CodUsu(nom, apell);
            try
            {
                string query = "UPDATE Tarea SET  Info ='" + correlativo + 
                    "', Descripcion='" + desc +
                    "', Tipo='" + tipo +
                    "', HoraProgramada ='" + fullHM + "', EstadoTarea='" + estado +
                    "' WHERE Info ='" + oldinfo +"' AND CodUsuario= '"+cod+ "';";


                SqlCommand micomando = new SqlCommand(query, objconexion.EstablecerConexion());
                SqlDataReader mireader;
                mireader = micomando.ExecuteReader();

                while (mireader.Read())
                {

                }
                //MessageBox.Show("Se modifico correctamente");

                objconexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar los registros, error: " + ex.ToString());
            }
        }

        public void ModificarEstado(string nom, string apell, string nuevoestado, int info)
        {
            Conexion objconexion = new Conexion();
            string cod = CodUsu(nom, apell);
            try
            {
                string query = "UPDATE Tarea SET  EstadoTarea ='" + nuevoestado +

                    "' WHERE Info ='" + info + "' AND CodUsuario= '" + cod + "';";


                SqlCommand micomando = new SqlCommand(query, objconexion.EstablecerConexion());
                SqlDataReader mireader;
                mireader = micomando.ExecuteReader();

                while (mireader.Read())
                {

                }
                //MessageBox.Show("Se modifico correctamente");

                objconexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar los registros, error: " + ex.ToString());
            }
        }
        public void Eliminar(int info)
        {
            Conexion objconexion = new Conexion();
            try
            {
                string query = "DELETE FROM Tarea WHERE Info ='" + info + "';";


                SqlCommand micomando = new SqlCommand(query, objconexion.EstablecerConexion());
                SqlDataReader mireader;
                mireader = micomando.ExecuteReader();

                while (mireader.Read())
                {

                }
                //MessageBox.Show("Se elimino correctamente");

                objconexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro eliminar los registros, error: " + ex.ToString());
            }
        }
    }
}
