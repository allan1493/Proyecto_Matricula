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
    public class LdGrupos
    {
        private SqlConnection _connection;
        public LdGrupos()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["Proyecto2DB"].ConnectionString;
        }
        #region metodos de insertar
        public int InsertarGrupos(string periodo, string materias, string numero, string horario, string capacidad, string estado)
        {
            int estudiante = 0;
            //Configura el command --->> crear una instrucción que se ejecuta en el Motor de BD
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spInsert_Grupos]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;
            try
            {
                //indicar los parámetros requeridos
                //parámetros de entrada
                cmdEjecutar.Parameters.AddWithValue("@materia", Int32.Parse(periodo));
                cmdEjecutar.Parameters.AddWithValue("@periodo", Int32.Parse(materias));
                cmdEjecutar.Parameters.AddWithValue("@numero", numero);
                cmdEjecutar.Parameters.AddWithValue("@horario", horario);
                cmdEjecutar.Parameters.AddWithValue("@capacidad", capacidad);
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
        #region consultar
        public DataTable consultaOfertaGrupo(string periodo, string carrera)
        {
            SqlCommand cmdEjecutar = new SqlCommand();
            cmdEjecutar.CommandText = "[dbo].[spSelect_OfertaGrupos]";
            cmdEjecutar.CommandType = CommandType.StoredProcedure;
            cmdEjecutar.Connection = _connection;
            try
            {
                //crear una estructura para almacenar los datos
                DataTable resultado = new DataTable("dtOferta");
                cmdEjecutar.Parameters.AddWithValue("@periodo", periodo);
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
    }
}
