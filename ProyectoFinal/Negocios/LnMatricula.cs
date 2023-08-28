using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class LnMatricula
    {
        public bool InsertarMatricula(string persona, string grupo, string fecha)
        {
            try
            {
                Datos.LdMatricula datos = new Datos.LdMatricula();
                //Data.LdMetodosAgendaBD datos = new Datos.LdMetodosAgendaBD();

                if (string.IsNullOrEmpty(persona))
                {
                    throw new Exception("El usuario no puede ser nulo o vacío.");
                }

                int resultado = datos.InsertarMatricula(persona, grupo, fecha);

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
        public bool EliminarMatricula(string persona, string grupo, string fecha, string actualizar)
        {
            try
            {
                Datos.LdMatricula datos = new Datos.LdMatricula();
                //Data.LdMetodosAgendaBD datos = new Datos.LdMetodosAgendaBD();

                if (string.IsNullOrEmpty(persona))
                {
                    throw new Exception("El usuario no puede ser nulo o vacío.");
                }

                int resultado = datos.EliminarMatricula(persona, grupo, fecha, actualizar);

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
    }
}
