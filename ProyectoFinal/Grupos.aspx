<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grupos.aspx.cs" Inherits="ProyectoFinal.Grupos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Oferta de Grupos</title>
   <link href="Style/Style.css" rel="stylesheet" />
    <script src="Scripts/General.js"></script>
    <style type="text/css">
        .auto-style1 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            width: 36%;
            padding: 10px;
            background-color: steelblue;
            color: black;
            border-radius: 5px;
            cursor: pointer;
            position: absolute;
            left: 63%;
            top: 570px;
        }
        .auto-style3 {
            padding: 9px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 6px;
            box-sizing: border-box;
        }
        .auto-style4 {
                  max-width: 470px;
                margin: -25px 0 0 -25px;
                background-color:lightblue;
                padding: 40px;
                border-radius: 20px;
                box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                position: absolute;
                top: 9%;
                left: 25%;
            height: 586px;
            width: 465px;
        }
        .auto-style6 {
            padding: 9px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 6px;
            box-sizing: border-box;
            margin-top: 2px;
        }
        .auto-style7 {
            padding: 9px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 6px;
            box-sizing: border-box;
            margin-top: 0px;
        }
        .auto-style8 {
            padding: 9px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 6px;
            box-sizing: border-box;
            margin-top: 22px;
        }
        .auto-style9 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            width: 36%;
            padding: 10px;
            background-color: steelblue;
            color: black;
            border-radius: 5px;
            cursor: pointer;
            position: absolute;
            left: 9%;
            top: 579px;
        }
            .auto-style12 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            width: 36%;
            padding: 10px;
            background-color: steelblue;
            color: black;
            border-radius: 5px;
            cursor: pointer;
            position: absolute;
            left: 9%;
            top: 625px;
        }
    </style>
</head>
<body>
    <form id="form_Carrera" runat="server">
        <div >
        <div class="auto-style4">
            <p>
                Materia a la que pertenece:</p>
            <asp:TextBox ID="txt_materia" CssClass="auto-style7" placeholder="Nombre Carrera" runat="server" Height="16px" Width="276px" OnTextChanged="nom_Carrera_TextChanged"></asp:TextBox>
            <br />
            Periodo:<br />
            <asp:TextBox ID="txt_periodo" CssClass="auto-style6" placeholder="Cantidad de estudiantes" runat="server" Height="20px" Width="276px"></asp:TextBox>
            <br />
            Numero de grupo<br />
            <asp:TextBox ID="txt_grupo" CssClass="auto-style3" placeholder="Cantidad de materias" runat="server" Height="22px" Width="274px"></asp:TextBox>
            <br />
            Horario:<br />
            &nbsp;<asp:TextBox ID="txt_horario" CssClass="auto-style3" placeholder="Cantidad de materias" runat="server" Height="22px" Width="274px"></asp:TextBox>
            <br />
            Capacidad<br />
            &nbsp;<asp:TextBox ID="txt_capacidad" CssClass="auto-style8" placeholder="Cantidad de materias" runat="server" Height="20px" Width="274px"></asp:TextBox>
            <br />
            Estado:<br />
            <br />
            <asp:TextBox ID="txt_estado" CssClass="auto-style3" placeholder="Cantidad de materias" runat="server" Height="22px" Width="274px"></asp:TextBox>
            <br />
            <asp:Button ID="btnCrear" CssClass="auto-style9" runat="server" Text="Agregar Grupo" OnClick="btnCrear_Click" />
            <br />
            <asp:Button ID="btnAtras" runat="server" CssClass="auto-style1" OnClick="btnAtras_Click" Text="Atras" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnOferta" runat="server" CssClass="auto-style12"  OnClick="btnOferta_Click" Text="Ver Oferta Grupos" />
            <br />
         </div>
        </div>
        
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
