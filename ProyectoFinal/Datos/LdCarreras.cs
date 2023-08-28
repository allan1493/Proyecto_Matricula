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
    public class LdCarreras
    {
        private SqlConnection _connection;
        public LdCarreras()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["Proyecto2DB"].ConnectionString;
        }

        #region metodos de consulta
        public DataTable ConsultaCarrera(string id)
        {
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spSelect_Carreras]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;
            try
            {
                //crear una estructura para almacenar los datos
                DataTable resultado = new DataTable("dtcarrera");
                cmdEjecutar.Parameters.AddWithValue("@carrera", id);
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
        public int InsertarCarreras(string nombreCarrera)
        {
            int estudiante = 0;
            //Configura el command --->> crear una instrucción que se ejecuta en el Motor de BD
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spInsert_Carrera]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;
            try
            {
                //indicar los parámetros requeridos
                //parámetros de entrada
                cmdEjecutar.Parameters.AddWithValue("@carrera", nombreCarrera);
                
               

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

        #region metodo de actualizar
        public int ActualizarCarrera(string nombreCarrera,string actualizar)

        {

            int estudiante = 0;

            //Configura el command --->> crear una instrucción que se ejecuta en el Motor de BD

            SqlCommand cmdEjecutar = new SqlCommand();

            cmdEjecutar.CommandText = "[dbo].[spUpdate_Carrera]";

            cmdEjecutar.CommandType = CommandType.StoredProcedure;

            cmdEjecutar.Connection = _connection;

            try

            {

                //indicar los parámetros requeridos

                //parámetros de entrada

                cmdEjecutar.Parameters.AddWithValue("@carrera", nombreCarrera);
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
