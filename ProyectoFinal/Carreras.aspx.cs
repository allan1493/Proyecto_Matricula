using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Carreras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void nom_Carrera_TextChanged(object sender, EventArgs e)
        {

        }

        protected void can_Estu0_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnVer_Click(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnCarreras estudiantes = new Negocios.LnCarreras();
                // Negocios.LnMetodosAgenda negocios = new Negocios.LnMetodosAgenda();



                //definir las variables
                string nombreCarrera = txt_Carrera.Text;
                
              
                var resultado = estudiantes.InsertarCarreras(nombreCarrera);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/VerCarreras.aspx");
        }

        protected void can_Estu_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnCarreras estudiantes = new Negocios.LnCarreras();
                // Negocios.LnMetodosAgenda negocios = new Negocios.LnMetodosAgenda();



                //definir las variables
                string nombreCarrera = txt_Carrera.Text;
                
                string actualizar = txt_Global.Text;


                var resultado = estudiantes.ActualizarCarrera(nombreCarrera, actualizar);
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

        protected void Ver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/VerCarreras.aspx");
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Prin_Admi.aspx");
        }
    }
}