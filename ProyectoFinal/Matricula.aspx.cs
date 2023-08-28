using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Matricula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void periodos_disponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void materias_grupos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Prin_Estu.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnMatricula estudiantes = new Negocios.LnMatricula();
                // Negocios.LnMetodosAgenda negocios = new Negocios.LnMetodosAgenda();

                //definir las variables
                string persona = txt_persona.Text;
                string grupo = txt_grupo.Text;
                string fecha = txt_fecha.Text;
               
                var resultado = estudiantes.InsertarMatricula(persona, grupo, fecha);
                //negocios.InsertarEstadoCivil(nombre);

                if (resultado)
                {    // Establecer el texto del mensaje
                    mensajeTexto.InnerText = "Se guardó la información correctamente";
                    // Mostrar el cuadro de mensaje
                    divMensaje.Style["display"] = "block";

                    // CargaTabla();
                }
                else
                {
                    // Establecer el texto del mensaje
                    mensajeTexto.InnerText = "Ocurrió un error al guardar la información, intentelo más tarde.";
                    // Mostrar el cuadro de mensaje
                    divMensaje.Style["display"] = "block";
                }
            }
            catch (Exception ex)
            {
                // Establecer el texto del mensaje
                mensajeTexto.InnerText = "Ocurrió un error. (Error: " + ex.Message + ")";
                // Mostrar el cuadro de mensaje
                divMensaje.Style["display"] = "block";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnMatricula estudiantes = new Negocios.LnMatricula();
                // Negocios.LnMetodosAgenda negocios = new Negocios.LnMetodosAgenda();

                //definir las variables
                string persona = txt_persona.Text;
                string grupo = txt_grupo.Text;
                string fecha = txt_fecha.Text;
                string actualizar = txt_Global.Text;

                var resultado = estudiantes.EliminarMatricula(persona, grupo, fecha, actualizar);
                //negocios.InsertarEstadoCivil(nombre);

                if (resultado)
                {    // Establecer el texto del mensaje
                    mensajeTexto.InnerText = "Se eliminó la información correctamente";
                    // Mostrar el cuadro de mensaje
                    divMensaje.Style["display"] = "block";

                    // CargaTabla();
                }
                else
                {
                    // Establecer el texto del mensaje
                    mensajeTexto.InnerText = "Ocurrió un error al eliminar la información, intentelo más tarde.";
                    // Mostrar el cuadro de mensaje
                    divMensaje.Style["display"] = "block";
                }
            }
            catch (Exception ex)
            {
                // Establecer el texto del mensaje
                mensajeTexto.InnerText = "Ocurrió un error. (Error: " + ex.Message + ")";
                // Mostrar el cuadro de mensaje
                divMensaje.Style["display"] = "block";
            }
        }
    }
}