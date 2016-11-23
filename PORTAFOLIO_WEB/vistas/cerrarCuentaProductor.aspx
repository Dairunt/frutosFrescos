<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cerrarCuentaProductor.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.cerrarCuentaProductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>

</head>
<body>
    <div class="wrap">
        <form id="form1" runat="server">
            <h1>Cerrar Cuenta</h1>
            <div>
                <h2>Su Cuenta Sera Cerrada En 15 Dias</h2>  
                <br />
                <br />
                <asp:Button ID="btnAceptar" runat="server" OnClick="Button1_Click" Text="ACEPTAR" />
                &nbsp;
                <asp:Button ID="btnCancelar" runat="server" OnClick="Button2_Click" Text="CANCELAR CIERRE DE CUENTA" />
                &nbsp;
                <asp:Button ID="btnVolverC" runat="server" OnClick="Button3_Click" Text="VOLVER" />
            </div>
        </form>

    </div>
</body>
</html>
