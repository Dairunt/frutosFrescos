<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validarCambiosProductor.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.validarCambiosProductor" %>

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
        <div>
    
            <h1>Aceptar Cambios</h1><br />
            <br />
            INGRESE CONTRASEÑA PARA ACEPTAR LOS CAMBIOS: 
            <asp:TextBox ID="txtCambio" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAceptar" runat="server" OnClick="Button1_Click" Text="ACEPTAR" />
            &nbsp;<asp:Button ID="btnVolverC" runat="server" Text="CANCELAR" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="lblRespuesta" runat="server"></asp:Label>
    
        </div>
        </form>
    </div>
</body>
</html>
