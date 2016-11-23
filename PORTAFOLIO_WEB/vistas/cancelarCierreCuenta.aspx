<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cancelarCierreCuenta.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.cancelarCierreCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>
<script type="text/javascript" src="vistas/JS/validarDatos.js"></script>
</script>
</head>
<body>
    <div class="wrap">
        <form id="form1" runat="server">
            CANCELAR CIERRE DE CUENTA<br />
            <br />
            <br />
            INGRESE CLAVE PARA CONFIRMAR:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="233px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAceptar" runat="server" OnClientClick="return validarCierre()" Text="ACEPTAR" OnClick="Button1_Click" />
            &nbsp;
            <asp:Button ID="btnVolverC" runat="server" Text="VOLVER" OnClick="Button3_Click" />
        </form>

    </div>
</body>
</html>
