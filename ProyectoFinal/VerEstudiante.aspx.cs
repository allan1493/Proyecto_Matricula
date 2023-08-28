using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class VerEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnEstudiantes negocios = new Negocios.LnEstudiantes(); 
                
                string id = txt_id.Text;
                var resultado = negocios.consultaInfoPersonal(id);
                GVEst.DataSource = resultado;
                
                GVEst.DataBind();
            }
            catch (Exception ex)
            {
                // Establecer el texto del mensaje
                mensajeTexto.InnerText = "Ocurrió un error. (Error: " + ex.Message + ")";
                // Mostrar el cuadro de mensaje
                divMensaje.Style["display"] = "block";
            }
        }

        protected void btnAcademica_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnEstudiantes negocios = new Negocios.LnEstudiantes();

                string id = txt_id.Text;
                var resultado = negocios.consultaInfoAcademica(id);
                GVEst.DataSource = resultado;

                GVEst.DataBind();
            }
            catch (Exception ex)
            {
                // Establecer el texto del mensaje
                mensajeTexto.InnerText = "Ocurrió un error. (Error: " + ex.Message + ")";
                // Mostrar el cuadro de mensaje
                divMensaje.Style["display"] = "block";
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Estudiantes.aspx");
        }
    }
}