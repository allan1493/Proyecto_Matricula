using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Materias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Ver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/VerMateria.aspx");

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnMateria estudiantes = new Negocios.LnMateria();
                // Negocios.LnMetodosAgenda negocios = new Negocios.LnMetodosAgenda();

                //definir las variables
                string carrera = txt_carrera.Text;
                string materia = txt_materia.Text;
                string creditos = txt_creditos.Text;
                string actualizar = txt_Global.Text;

                var resultado = estudiantes.ActualizarMateria(carrera, materia, creditos, actualizar);
                //negocios.InsertarEstadoCivil(nombre);

                if (resultado)
                {    // Establecer el texto del mensaje
                    mensajeTexto.InnerText = "Se actualizó la información correctamente";
                    // Mostrar el cuadro de mensaje
                    divMensaje.Style["display"] = "block";

                    // CargaTabla();
                }
                else
                {
                    // Establecer el texto del mensaje
                    mensajeTexto.InnerText = "Ocurrió un error al actualizar la información, intentelo más tarde.";
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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                Negocios.LnMateria estudiantes = new Negocios.LnMateria();
                // Negocios.LnMetodosAgenda negocios = new Negocios.LnMetodosAgenda();

                //definir las variables
                string carrera = txt_carrera.Text;
                string materia = txt_materia.Text;
                string creditos = txt_creditos.Text;
                
                var resultado = estudiantes.InsertarMateria(carrera, materia, creditos);
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

    }
}