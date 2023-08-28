using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class VerCarreras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Carreras.aspx");
        }

        protected void btnCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnCarreras negocios = new Negocios.LnCarreras();

                string id = txt_carrera.Text;
                var resultado = negocios.ConsultaCarrera(id);
                GVMat.DataSource = resultado;

                GVMat.DataBind();
            }
            catch (Exception ex)
            {
                // Establecer el texto del mensaje
                mensajeTexto.InnerText = "Ocurrió un error. (Error: " + ex.Message + ")";
                // Mostrar el cuadro de mensaje
                divMensaje.Style["display"] = "block";
            }
        }

        protected void btnMateria_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnCarreras negocios = new Negocios.LnCarreras();

                string id = txt_carrera.Text;
                var resultado = negocios.ConsultaCarrera(id);
                GVMat.DataSource = resultado;

                GVMat.DataBind();
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