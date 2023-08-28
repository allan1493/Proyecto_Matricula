<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prin_Admi.aspx.cs" Inherits="ProyectoFinal.Prin_Admi" %>

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
        .materia {
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
            left: 13%;
            top: 148px;
        }
        .estu {
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
            left: 13%;
            top: 220px;
            margin-top: 0px;
        }
        .grupo {
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
            left: 13%;
            top: 292px;
        }
        .carrera {
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
            left: 13%;
            top: 372px;
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
            left: 13%;
            top: 372px;
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
            left: 13%;
            top: 434px;
        }
    </style>
</head>
<body>
    <form id="Prin_Admi" runat="server">
        <div class="Prin" >
             <h1>Menu del Administrador</h1>
            <asp:Button ID="carreras" CssClass="carrera" runat="server" Text="Módulo de carreras" OnClick="carreras_Click" />
            <asp:Button ID="grupos" CssClass="grupo" runat="server" Text="Módulo de Oferta de Grupos" OnClick="grupos_Click" />
            <asp:Button ID="estudiantes" CssClass="estu" runat="server" Text="Módulo de administración de estudiantes" OnClick="estudiantes_Click" />
            <asp:Button ID="materias" CssClass="materia" runat="server" Text="Módulo de materias" OnClick="materias_Click" />
            <asp:Button ID="salir" CssClass="salir" runat="server" Text="Salir" OnClick="salir_Click" />
</div>
    </form>
</body>
</html>
