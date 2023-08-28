using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class LnGrupos
    {
        #region Escritura
        public bool InsertarGrupos(string periodo, string materias, string numero, string horario, string capacidad, string estado)
        {
            try
            {
                Datos.LdGrupos datos = new Datos.LdGrupos();
                //Data.LdMetodosAgendaBD datos = new Datos.LdMetodosAgendaBD();

                if (string.IsNullOrEmpty(materias))
                {
                    throw new Exception("El estado civil no puede ser nulo o vacío.");
                }

                int resultado = datos.InsertarGrupos(materias, periodo, numero, horario, capacidad, estado);

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
        #region Consulta
        public DataTable consultaOfertaGrupo(string periodo, string carrera)
        {
            try
            {
                Datos.LdGrupos datos = new Datos.LdGrupos();



                return datos.consultaOfertaGrupo(periodo, carrera);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
