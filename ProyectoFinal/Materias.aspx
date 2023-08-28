<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="ProyectoFinal.Materias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Materias</title>
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
            left: 59%;
            top: 386px;
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
            left: 4%;
            top: 384px;
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
            right: 200px;
        }
        .auto-style5 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            width: 59%;
            padding: 10px;
            background-color: steelblue;
            color: black;
            border-radius: 5px;
            cursor: pointer;
            position: absolute;
            left: 5%;
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
            width: 47%;
            padding: 10px;
            background-color: steelblue;
            color: black;
            border-radius: 5px;
            cursor: pointer;
            position: absolute;
            left: 59%;
            top: 448px;
            margin-bottom: 6px;
        }
    </style>
</head>
<body>
     
           
    <form id="form_Carrera" runat="server">
        <div >
        <div class="auto-style4">
            <p>
                Carrera a la que pertenece:</p>
            <asp:TextBox ID="txt_carrera" CssClass="auto-style3" placeholder="Nombre Carrera" runat="server" Height="16px" Width="276px" OnTextChanged="nom_Carrera_TextChanged"></asp:TextBox>
            <br />
            Nombre de la materia:<br />
            <asp:TextBox ID="txt_materia" CssClass="auto-style6" placeholder="Cantidad de estudiantes" runat="server" Height="20px" Width="276px"></asp:TextBox>
            <br />
            Cantidad de creditos:<br />
            <br />
            <asp:Button ID="btnActualizar" CssClass="auto-style2" runat="server" Text="Actualizar materia" OnClick="btnActualizar_Click" />
            <asp:TextBox ID="txt_creditos" CssClass="auto-style3" placeholder="Cantidad de materias" runat="server" Height="22px" Width="274px"></asp:TextBox>
            <br />
            <br />
            Renombrar materia:<br />
            <asp:TextBox ID="txt_Global" CssClass="auto-style3" placeholder="" runat="server" Height="16px" Width="276px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnGuardar" CssClass="auto-style1" runat="server" Text="Crear Materia" OnClick="btnGuardar_Click" />
            <br />
            <br />
            <asp:Button ID="btnAtras" runat="server" CssClass="auto-style7" OnClick="btnAtras_Click" Text="Atras" />
            <asp:Button ID="btnVer" runat="server" CssClass="auto-style5" OnClick="Ver_Click" Text="Listar Materia" />
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
