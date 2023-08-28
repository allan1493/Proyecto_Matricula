using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {/*Cambiar esta parte por que va conectada en la db*/
            string user = txtLogin.Text;
            string password = txtpassword.Text;

            if (user == "admi" && password == "admi")
            {
                Response.Redirect("/Prin_Admi.aspx");//si el usuario es administrador,va directo al form de Prin_Admi
            }
            else if (user == "estu" && password == "estu")
            {
                Response.Redirect("/Prin_Estu.aspx");// si el usuario es Estu, va directo al form de Prin_Estu
            }

        }
    }
}