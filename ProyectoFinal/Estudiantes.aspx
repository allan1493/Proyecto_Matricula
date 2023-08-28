<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estudiantes.aspx.cs" Inherits="ProyectoFinal.Estudiantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administracion de Estudiantes</title>
    <link href="Style/Style.css" rel="stylesheet" />
    <script src="Scripts/General.js"></script>
</head>
<body>
    <form id="form_Estu" runat="server">
        <div>
        </div>
        
            <table class="centrar-Prin text-center tablaLogin" >
                <tr>
                <td colspan="2" class="h1Prin"><h1>Administrar Estudiantes</h1></td>
                </tr>
                <tr>
                <td colspan="2" class="h1Prin"><h3>Información Personal</h3></td>
                </tr>
                <tr>
                <td><asp:Label ID="Luser" runat="server" Text="Usuario:"></asp:Label></td>
                <td><asp:TextBox ID="txt_user" runat="server" Width="235px"></asp:TextBox></td>
                 </tr>
                 <tr>
                <td><asp:Label ID="Nombre" runat="server" Text="Nombre:"></asp:Label></td>
                <td><asp:TextBox ID="txt_Nombre" runat="server" Width="235px"></asp:TextBox></td>
                 </tr>
                 <tr>
                <td><asp:Label ID="Apellidos" runat="server" Text="Apellidos:"></asp:Label></td>
                <td><asp:TextBox ID="txt_apellidos" runat="server" Width="235px"></asp:TextBox></td>
                 </tr>
                
                <tr>
                <td><asp:Label ID="identificacion" runat="server" Text="Identificación"></asp:Label></td>
                <td><asp:TextBox ID="txt_identi" runat="server" Width="235px"></asp:TextBox></td>
                 </tr>
               
                <tr>
                    <td><asp:Label ID="lblTI" runat="server" Text="Tipo de identificación"></asp:Label></td>
                    <td> <asp:DropDownList ID="DDLId" runat="server"></asp:DropDownList></td>
                 </tr>
                
                <tr>
                <td><asp:Label ID="lblGenero" runat="server" Text="Género"></asp:Label></td>
                <td><asp:DropDownList ID="DDLGenero" runat="server"></asp:DropDownList></td>
                 </tr>
                <tr>
                    <td><asp:Label ID="lblEC" runat="server" Text="Estado Civil"></asp:Label></td>
                    <td><asp:DropDownList ID="DDLCivil" runat="server"></asp:DropDownList></td>
                 </tr>
                <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Fecha de Nacimiento"></asp:Label></td>
                    <td><asp:TextBox ID="txtFN" runat="server" Width="235px"></asp:TextBox></td>
                    </tr>
                </table>
        <table>
            <tr>
                <td colspan="2" class="h1Prin"><h3>Información Academica</h3></td>
                </tr>
                 <tr>
                <td><asp:Label ID="lblCarrera" runat="server" Text="Carrera: "></asp:Label></td>
                <td><asp:TextBox ID="txt_carrera" runat="server" Width="235px"></asp:TextBox></td>
                 </tr>
                 <tr>
                
                <td><asp:Label ID="lblanio" runat="server" Text="Año de Ingreso: "></asp:Label></td>
                <td><asp:TextBox ID="txt_anio" runat="server" Width="235px"></asp:TextBox></td>
                </tr>
                <tr>
                <td><asp:Label ID="lblCE" runat="server" Text="Estado: "></asp:Label></td>
                <td><asp:DropDownList ID="DDLEstado" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                 <td><asp:Button ID="btnGuardar" runat="server" class="btnPrin" Text="Guardar" OnClick="btnGuardar_Click"  /></td>
                    <td><asp:Button ID="btnSelect" runat="server" class="btnPrin" Text="Visualizar Info" OnClick="btnVisualizar_Click"  /></td>
                 <td><asp:Button ID="btnMenu" runat="server" class="btnPrin" Text="Volver a Menú" OnClick="btnSalir_Click"  /></td> 
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
