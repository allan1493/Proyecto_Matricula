<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prin_Estu.aspx.cs" Inherits="ProyectoFinal.Prin_Estu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Principal</title>
    <link href="Style/Style.css" rel="stylesheet" />
     <style type="text/css">/*estilos de los botones y fondos*/
        .Prin {
            max-width: 470px;
            margin: -25px 0 0 -25px;
            background-color: lightblue;
            padding: 40px;
            border-radius: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            position: absolute;
            top: 17%;
            left: 31%;
            height: 451px;
            width: 429px;
        }
         .matricula {
             border-style: none;
             border-color: inherit;
             border-width: medium;
             width: 77%;
             padding: 10px;
             background-color: steelblue;
             color: black;
             border-radius: 5px;
             cursor: pointer;
             position: absolute;
             left: 16%;
             top: 149px;
         }
         .salir {
             border-style: none;
             border-color: inherit;
             border-width: medium;
             width: 77%;
             padding: 10px;
             background-color: steelblue;
             color: black;
             border-radius: 5px;
             cursor: pointer;
             position: absolute;
             left: 16%;
             top: 244px;
         }
    </style>
</head>
<body>
    <form id="Prin_Estu" runat="server">
        <div>
            <div class="Prin" >
             <h1>Menu del Estudiante</h1>
            <asp:Button ID="matricula" CssClass="matricula" runat="server" Text="Matricula" OnClick="matricula_Click" />
            <asp:Button ID="salir" CssClass="salir" runat="server" Text="Salir" OnClick="salir_Click" />    
        </div>
        </div>
    </form>
</body>
</html>
