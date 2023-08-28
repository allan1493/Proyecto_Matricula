using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class LnEstudiantes
    {
        #region consulta

        public DataTable consultaInfoPersonal(string id) {
            try
            {
                Datos.LdEstudiantes datos = new Datos.LdEstudiantes();
                
                

                return datos.ConsultaInfoPersonal(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable consultaInfoAcademica(string id)
        {
            try
            {
                Datos.LdEstudiantes datos = new Datos.LdEstudiantes();



                return datos.ConsultaInfoAcademica(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion
        #region Escritura
        public bool InsertarEstudiante(string user, string carrera, string nombre, string apellidos, string id, int tipo, int genero, int civil, string nacimiento, string ingreso, int estado)
        {
            try
            {
                Datos.LdEstudiantes datos = new Datos.LdEstudiantes();
                //Data.LdMetodosAgendaBD datos = new Datos.LdMetodosAgendaBD();

                if (string.IsNullOrEmpty(nombre))
                {
                    throw new Exception("El estado civil no puede ser nulo o vacío.");
                }

                int resultado = datos.InsertarEstudiante(user, carrera, nombre, apellidos, id, tipo, genero, civil, nacimiento, ingreso, estado);

                if (resultado > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
