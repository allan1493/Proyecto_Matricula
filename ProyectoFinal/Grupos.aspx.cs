using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Grupos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnGrupos estudiantes = new Negocios.LnGrupos();
                // Negocios.LnMetodosAgenda negocios = new Negocios.LnMetodosAgenda();

                //definir las variables
                string materia = txt_materia.Text;
                string periodo = txt_periodo.Text;
                string grupo = txt_grupo.Text;
                string horario = txt_horario.Text;
                string capacidad = txt_capacidad.Text;
                string estado = txt_estado.Text;





                var resultado = estudiantes.InsertarGrupos(periodo, materia, grupo, horario, capacidad, estado);
                //negocios.InsertarEstadoCivil(nombre);

                if (resultado)
                {    // Establecer el texto del mensaje
                    mensajeTexto.InnerText = "Se almacenó la información correctamente";
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

        protected void nom_Carrera_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Prin_Admi.aspx");
        }

        protected void btnOferta_Click(object sender, EventArgs e)
        {
            Response.Redirect("/VerGrupo.aspx");
        }
    }
}