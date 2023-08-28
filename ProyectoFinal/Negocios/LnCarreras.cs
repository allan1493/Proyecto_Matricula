using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class LnCarreras
    {
        #region consulta

        public DataTable ConsultaCarrera(string id)
        {
            try
            {
                Datos.LdCarreras datos = new Datos.LdCarreras();



                return datos.ConsultaCarrera(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion
        #region Escritura
        public bool InsertarCarreras(string nombreCarrera)
        {
            try
            {
                Datos.LdCarreras datos = new Datos.LdCarreras();
                //Data.LdMetodosAgendaBD datos = new Datos.LdMetodosAgendaBD();

                if (string.IsNullOrEmpty(nombreCarrera))
                {
                    throw new Exception("El estado civil no puede ser nulo o vacío.");
                }

                int resultado = datos.InsertarCarreras(nombreCarrera);

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

        #region Actualizar
        public bool ActualizarCarrera(string nombreCarrera,string actualizar)
        {
            try
            {
                Datos.LdCarreras datos = new Datos.LdCarreras();
                //Data.LdMetodosAgendaBD datos = new Datos.LdMetodosAgendaBD();



                if (string.IsNullOrEmpty(nombreCarrera))
                {
                    throw new Exception("El estado civil no puede ser nulo o vacío.");
                }



                int resultado = datos.ActualizarCarrera(nombreCarrera, actualizar);



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
