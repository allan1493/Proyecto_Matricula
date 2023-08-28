using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class LnMateria
    {
        #region consulta

        public DataTable consultaMateria(string carrera)
        {
            try
            {
                Datos.LdMateria datos = new Datos.LdMateria();



                return datos.consultaMateria(carrera);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool InsertarMateria(string carrera, string materia, string creditos)
        {
            try
            {
                Datos.LdMateria datos = new Datos.LdMateria();
                //Data.LdMetodosAgendaBD datos = new Datos.LdMetodosAgendaBD();

                if (string.IsNullOrEmpty(carrera))
                {
                    throw new Exception("El estado civil no puede ser nulo o vacío.");
                }

                int resultado = datos.InsertarMateria(carrera, materia, creditos);

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
        public bool ActualizarMateria(string carrera, string materia, string creditos, string actualizar)
        {
            try
            {
                Datos.LdMateria datos = new Datos.LdMateria();
                //Data.LdMetodosAgendaBD datos = new Datos.LdMetodosAgendaBD();

                if (string.IsNullOrEmpty(carrera))
                {
                    throw new Exception("El estado civil no puede ser nulo o vacío.");
                }

                int resultado = datos.ActualizarMateria(carrera, materia, creditos, actualizar);

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
