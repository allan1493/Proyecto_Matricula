<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerGrupo.aspx.cs" Inherits="ProyectoFinal.VerGrupo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Oferta Grupos</title>
    <link href="Style/Style.css" rel="stylesheet" />
    <script src="Scripts/General.js"></script>
</head>
<body>
    <form id="form_VGrupo" runat="server">
        <div>
        </div><table>
            <tr>
                <td colspan="2" class="h1Prin"><h3>Informacion Oferta de Grupo</h3></td>
                </tr>
                <tr>
                <td><asp:Label ID="LPeriodo" runat="server" Text="Periodo: "></asp:Label></td>
                <td><asp:TextBox ID="txt_periodo" runat="server" Width="235px"></asp:TextBox></td>
                 </tr>
            <tr>
                <td><asp:Label ID="LCarrera" runat="server" Text="Carrera: "></asp:Label></td>
                <td><asp:TextBox ID="txt_carrera" runat="server" Width="235px"></asp:TextBox></td>
            </tr>
            <tr>
                 <td><asp:Button ID="btnGrupo" runat="server" class="btnPrin" Text="Oferta de Grupos" OnClick="btnGrupo_Click"  /></td>
                    
                    
                 <td><asp:Button ID="btnMenu" runat="server" class="btnPrin" Text="Volver a Menú" OnClick="btnSalir_Click"  /></td> 
                </tr>
            
                
        </table>
        <table>
            <tr>
          <td>  <asp:GridView ID="GVOferta" CssClass="gridview" runat="server"></asp:GridView> </td>
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
