using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class VerGrupo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnGrupos negocios = new Negocios.LnGrupos();   

                string periodo = txt_periodo.Text;  
                string id = txt_carrera.Text;
                var resultado = negocios.consultaOfertaGrupo(periodo, id);
                GVOferta.DataSource = resultado;

                GVOferta.DataBind();
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
            Response.Redirect("/Grupos.aspx");
        }
    }
}