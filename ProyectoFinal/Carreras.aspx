<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carreras.aspx.cs" Inherits="ProyectoFinal.Carreras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Carreras</title>
    <link href="Style/Style.css" rel="stylesheet" />
    <script src="Scripts/General.js"></script>
    <style type="text/css">
        .auto-style1 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            width: 47%;
            padding: 10px;
            background-color: steelblue;
            color: black;
            border-radius: 5px;
            cursor: pointer;
            position: absolute;
            left: 69%;
            top: 381px;
        }
        .auto-style2 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            width: 61%;
            padding: 10px;
            background-color: steelblue;
            color: black;
            border-radius: 5px;
            cursor: pointer;
            position: absolute;
            left: 2%;
            top: 385px;
            margin-bottom: 6px;
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
                top: 23%;
                left: 38%;
            height: 467px;
            width: 332px;
        }
        .auto-style5 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            width: 61%;
            padding: 10px;
            background-color: steelblue;
            color: black;
            border-radius: 5px;
            cursor: pointer;
            position: absolute;
            left: 62%;
            top: 449px;
            margin-bottom: 6px;
        }
        .auto-style6 {
            padding: 9px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 6px;
            box-sizing: border-box;
            margin-top: 30px;
        }
        .auto-style7 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            width: 61%;
            padding: 10px;
            background-color: steelblue;
            color: black;
            border-radius: 5px;
            cursor: pointer;
            position: absolute;
            left: 2%;
            top: 447px;
            margin-bottom: 6px;
        }
    </style>
</head>
<body>
    
    <form id="form_Carrera" runat="server">
        <div >
        <div class="auto-style4">
            <p>
                Nombre de la carrera:</p>
            <asp:TextBox ID="txt_Carrera" CssClass="auto-style3" placeholder="Nombre Carrera" runat="server" Height="16px" Width="276px" OnTextChanged="nom_Carrera_TextChanged"></asp:TextBox>
            <br /><br />
            <p>Renombrar carrera</p>
            <asp:TextBox ID="txt_Global" CssClass="auto-style3" placeholder="Nuevo Nombre" runat="server" Height="16px" Width="276px"></asp:TextBox>
            <br /><br />
            
            <br />
            <asp:Button ID="btnActualizar" CssClass="auto-style2" runat="server" Text="Actualizar Carrera" OnClick="btnActualizar_Click" /><br />
            
            <br />
            <br />
            <asp:Button ID="btnCrear" CssClass="auto-style1" runat="server" Text="Crear Carrera" OnClick="btnCrear_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnAtras" runat="server" CssClass="auto-style5" OnClick="btnAtras_Click" Text="Atras" />
            <asp:Button ID="btnVer" runat="server" CssClass="auto-style7" OnClick="Ver_Click" Text="Listar Materia" />
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
