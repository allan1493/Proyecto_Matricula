<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerEstudiante.aspx.cs" Inherits="ProyectoFinal.VerEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Info Estudiante</title>
    <link href="Style/Style.css" rel="stylesheet" />
    <script src="Scripts/General.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table>
            <tr>
                <td colspan="2" class="h1Prin"><h3>Información Personal</h3></td>
                </tr>
                <tr>
                <td><asp:Label ID="LId" runat="server" Text="Identificacion: "></asp:Label></td>
                <td><asp:TextBox ID="txt_id" runat="server" Width="235px"></asp:TextBox></td>
                 </tr>
            <tr>
                 <td><asp:Button ID="btnPersonal" runat="server" class="btnPrin" Text="Info. Personal" OnClick="btnPersonal_Click"  /></td>
                    <td><asp:Button ID="btnAcademica" runat="server" class="btnPrin" Text="Info. Academica" OnClick="btnAcademica_Click" Width="218px"  /></td>
                    
                 <td><asp:Button ID="btnMenu" runat="server" class="btnPrin" Text="Volver a Menú" OnClick="btnSalir_Click"  /></td> 
                </tr>
            
                
        </table>
        <table>
            <tr>
          <td>  <asp:GridView ID="GVEst" CssClass="gridview" runat="server"></asp:GridView> </td>
        </tr>
        </table>
    </form>
    <div class="dialog-container" id="divMensaje" style="display: none;" runat="server">
        <div class="message-box">
            <div id="mensajeContenido">
                <span id="mensajeTexto" runat="server"></span>
                <button id="cerrarMensaje" class="btnClass btnMensaje" onclick="cerrarMensaje()">Cerrar</button>
            </div>
        </div>
    </div>
</body>
</html>
