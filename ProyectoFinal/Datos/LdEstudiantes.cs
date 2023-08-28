using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class LdEstudiantes
    {
        private SqlConnection _connection;
        public LdEstudiantes() {
            InitConnection();
        }

        private void InitConnection()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["Proyecto2DB"].ConnectionString;
        }

        #region metodos de consulta
        public DataTable ConsultaInfoPersonal(string id) {
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spSelect_infoPersonal]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection; 
            try
            {
                //crear una estructura para almacenar los datos
                DataTable resultado = new DataTable("dtInfoPersonal");
                cmdEjecutar.Parameters.AddWithValue("@identificacion", id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdEjecutar);

                //ejecutar
                //abrir la conexion
                _connection.Open();
                adapter.Fill(resultado);

                //cerramos la db
                _connection.Close();
                cmdEjecutar.Dispose();

                return resultado;
            }
            catch (Exception ex)
            {
                //cerramos la db
                _connection.Close();
                cmdEjecutar.Dispose();

                throw new Exception(ex.Message);
            }
        }

        public DataTable ConsultaInfoAcademica(string id)
        {
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spSelect_infoAcademica]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;
            try
            {
                //crear una estructura para almacenar los datos
                DataTable resultado = new DataTable("dtInfoAcademica");
                cmdEjecutar.Parameters.AddWithValue("@identificacion", id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdEjecutar);

                //ejecutar
                //abrir la conexion
                _connection.Open();
                adapter.Fill(resultado);

                //cerramos la db
                _connection.Close();
                cmdEjecutar.Dispose();

                return resultado;
            }
            catch (Exception ex)
            {
                //cerramos la db
                _connection.Close();
                cmdEjecutar.Dispose();

                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region metodos de insertar

        
        public int InsertarEstudiante(string user, string carrera, string nombre, string apellidos, string id, int tipo, int genero, int civil, string nacimiento, string ingreso, int estado)
        {
            int estudiante = 0;
            //Configura el command --->> crear una instrucción que se ejecuta en el Motor de BD
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spINSERT_dbo_Persona]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;
            try
            {
                //indicar los parámetros requeridos
                //parámetros de entrada
                cmdEjecutar.Parameters.AddWithValue("@usuario", Int32.Parse(user));
                cmdEjecutar.Parameters.AddWithValue("@carrera", Int32.Parse(carrera));
                cmdEjecutar.Parameters.AddWithValue("@nombre", nombre);
                cmdEjecutar.Parameters.AddWithValue("@apellidos", apellidos);
                cmdEjecutar.Parameters.AddWithValue("@identificacion", id);
                cmdEjecutar.Parameters.AddWithValue("@tipo", tipo);
                cmdEjecutar.Parameters.AddWithValue("@genero", genero);
                cmdEjecutar.Parameters.AddWithValue("@civil", civil);
                cmdEjecutar.Parameters.AddWithValue("@nacimiento", nacimiento);
                cmdEjecutar.Parameters.AddWithValue("@ingreso", ingreso);
                cmdEjecutar.Parameters.AddWithValue("@estado", estado);




                //ejecutar
                _connection.Open();
                cmdEjecutar.ExecuteNonQuery();
                _connection.Close();
                //revisar los parametros



                //// en dado caso que sea boolean
                //if (idEstadoCivil > 0)
                //{
                //    return true;
                //}

                //return false;
                estudiante++;
                return estudiante;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
                cmdEjecutar.Dispose();
            }


        }


        #endregion

    }
}
