<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmarCierreCuenta.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.confirmarCierreCuenta" %>

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
        <form id="form1" runat="server">
        <div>
    
            <h1>CONFIRMAR CIERRE DE CUENTA</h1>
            <br />
            <br />
            <br />
            INGRESE CLAVE PARA CONFIRMAR: 
            <asp:TextBox ID="txtIngrese" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" onClientClick="return validarIngreso()" />
            &nbsp;
            <asp:Button ID="btnVolverC" runat="server" Text="VOLVER" OnClick="Button3_Click" />
    
        </div>
        </form>
    </div>
</body>
</html>
