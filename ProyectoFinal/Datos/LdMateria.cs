using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LdMateria
    {
        private SqlConnection _connection;
        public LdMateria()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["Proyecto2DB"].ConnectionString;
        }

        #region metodos de consulta
        public DataTable consultaMateria(string carrera)
        {
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spSelect_Materias]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;
            try
            {
                //crear una estructura para almacenar los datos
                DataTable resultado = new DataTable("dtMateria");
                cmdEjecutar.Parameters.AddWithValue("@carrera", carrera);
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
        public int InsertarMateria(string carrera, string materia, string creditos)
        {
            int estudiante = 0;
            //Configura el command --->> crear una instrucción que se ejecuta en el Motor de BD
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spInsert_Materia]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;
            try
            {
                //indicar los parámetros requeridos
                //parámetros de entrada
                cmdEjecutar.Parameters.AddWithValue("@carrera", Int32.Parse(carrera));
                cmdEjecutar.Parameters.AddWithValue("@nombre", materia);
                cmdEjecutar.Parameters.AddWithValue("@creditos", creditos);





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

        #region metodos de actualizar
        public int ActualizarMateria(string carrera, string materia, string creditos, string actualizar)
        {
            int estudiante = 0;
            //Configura el command --->> crear una instrucción que se ejecuta en el Motor de BD
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spUpdate_Materia]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;
            try
            {
                //indicar los parámetros requeridos
                //parámetros de entrada
                cmdEjecutar.Parameters.AddWithValue("@materia", materia);
                cmdEjecutar.Parameters.AddWithValue("@carrera", Int32.Parse(carrera));
                cmdEjecutar.Parameters.AddWithValue("@creditos", creditos);
                cmdEjecutar.Parameters.AddWithValue("@actualizar", actualizar);

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

