using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Prin_Admi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void estudiantes_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Estudiantes.aspx");
        }

        protected void salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }

        protected void carreras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Carreras.aspx");
        }

        protected void grupos_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Grupos.aspx");
        }

        protected void materias_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Materias.aspx");
        }
    }
}