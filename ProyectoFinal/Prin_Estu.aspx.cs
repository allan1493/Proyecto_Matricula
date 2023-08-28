using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Prin_Estu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }

        protected void matricula_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Matricula.aspx");
        }
    }
}