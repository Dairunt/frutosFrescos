<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cambiarContraseniaProductor.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.cambiarContraseniaProductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>
<script type="text/javascript" src="vistas/JS/validarDatos.js"></script>
</head>
<body>
    <div class="wrap">
        <form id="form1" runat="server" onsubmit="return validarDatos()">
        <div>
    
            <h1>Modificar Contraseña</h1>
            <br />
            <br />
            CONTRASEÑA ACTUAL:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCActual" runat="server" Width="212px"></asp:TextBox>
            <br />
            <br />
            NUEVA CONTRASEÑA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtCNueva" runat="server" Width="212px"></asp:TextBox>
            <br />
            <br />
            CONFIRMAR NUEVA CONTRASEÑA:&nbsp;
            <asp:TextBox ID="txtConfirmarCNueva" runat="server" Width="212px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClientClick="return validarClave()" OnClick="Button1_Click" Text="ACEPTAR" Width="192px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="CANCELAR" Width="192px" />
    
        </div>
        </form>

    </div>
</body>
</html>
