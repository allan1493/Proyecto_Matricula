<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Matricula.aspx.cs" Inherits="ProyectoFinal.Matricula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matricula</title>
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
            left: 55%;
            top: 407px;
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
            left: 11%;
            top: 404px;
        }
        .auto-style8 {
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
            left: 30%;
            top: 330px;
        }
    </style>
</head>
<body>
     <asp:TextBox ID="txt_Global" CssClass="auto-style3" placeholder="" runat="server" Height="16px" Width="276px" visible="false"></asp:TextBox>
           
    <form id="form_Carrera" runat="server">
        <div >
        <div class="auto-style4">
            <p>Matricula:</p>
            <p>Persona:</p>
            <asp:TextBox ID="txt_persona" CssClass="auto-style6" placeholder="Nombre:" runat="server" Height="16px" Width="276px" ></asp:TextBox>
            <br />
            Grupo:<br />
            <asp:TextBox ID="txt_grupo" CssClass="auto-style6" placeholder="Grupo:" runat="server" Height="20px" Width="276px" ></asp:TextBox>
            <br />
            Fecha:<br />
            <br />
           <asp:TextBox ID="txt_fecha" CssClass="auto-style6" placeholder="Fecha:" runat="server" Height="20px" Width="276px" ></asp:TextBox>
            
            <br />
            <br />
            <asp:Button ID="btnGuardar" CssClass="auto-style8" runat="server" Text="Guardar matricula" OnClick="btnGuardar_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Eliminar" CssClass="auto-style1" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Atras" runat="server" CssClass="auto-style7" OnClick="btnAtras_Click" Text="Atras" />
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
