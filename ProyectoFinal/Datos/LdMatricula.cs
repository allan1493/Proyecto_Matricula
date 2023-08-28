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
    public class LdMatricula
    {
        private SqlConnection _connection;
        public LdMatricula()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["Proyecto2DB"].ConnectionString;
        }

        #region metodos de eliminar
        public int InsertarMatricula(string persona, string grupo, string fecha)
        {
            int estudiante = 0;
            //Configura el command --->> crear una instrucción que se ejecuta en el Motor de BD
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spMatricular]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;
            try
            {
                //indicar los parámetros requeridos
                //parámetros de entrada
                cmdEjecutar.Parameters.AddWithValue("@alumno", Int32.Parse(persona));
                cmdEjecutar.Parameters.AddWithValue("@grupo", Int32.Parse(grupo));
                cmdEjecutar.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha));


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
        public int EliminarMatricula(string persona, string grupo, string fecha, string actualizar)

        {

            int estudiante = 0;

            //Configura el command --->> crear una instrucción que se ejecuta en el Motor de BD
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spDelete_Matricula]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;

            try

            {

                //indicar los parámetros requeridos

                //parámetros de entrada

                cmdEjecutar.Parameters.AddWithValue("@alumno", Int32.Parse(persona));
                cmdEjecutar.Parameters.AddWithValue("@grupo", Int32.Parse(grupo));
                

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
