using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class VerMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void VerMateria_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.LnMateria negocios = new Negocios.LnMateria();

                string id = txt_carrera.Text;
                var resultado = negocios.consultaMateria(id);
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

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Materias.aspx");
        }
    }
}