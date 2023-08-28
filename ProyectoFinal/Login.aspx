<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoFinal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/Style.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
    <form id="loginform" runat="server">
      <div>
             <div>
            <table class="centrar-elemento text-center tablaLogin" >
                <tr>
                    <td ><img class="imgLogin" src="Img/libro.jpg" /></td>
                    <tr>
                    <td> <asp:TextBox ID="txtLogin" runat="server" CssClass="estandarTexbox" placeholder="Usuario"></asp:TextBox></td>
               </tr>
                </tr>
                <tr>
                    <td> <asp:TextBox ID="txtpassword" runat="server" placeholder="Contraseña" TextMode="Password" CssClass="estandarTexbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesion" CssClass="btnButton" OnClick="btnLogin_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                         <asp:Label ID="lblMensaje" runat="server" Visible="False"></asp:Label> </td>
                </tr>
            </table>
        </div>
        </div>       
    </form>
</body>
</html>
