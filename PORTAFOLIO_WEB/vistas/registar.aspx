<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script type="text/javascript" src="vistas/JS/validarDatos.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>
</head>
<body>
    <div class="wrap">
        <h1>Formulario de Registro</h1>    
        <form id="form1" runat="server">
            <asp:Label Text="RUT: " runat="server" />
            <asp:TextBox ID="txtRut" runat="server" />
            <br />
            <br />
            <asp:Label Text="NOMBRE: " runat="server" />
            <asp:TextBox ID="txtNombre" runat="server" />
            <br />
            <br />
            <asp:Label Text="APELLIDO PATERNO: " runat="server" />
            <asp:TextBox ID="txtApellidoP" runat="server" />
            <br />
            <br />
            <asp:Label Text="APELLIDO MATERNO: " runat="server" />
            <asp:TextBox ID="txtApellidoM" runat="server" />
            <br />
            <br />
            <asp:Label Text="CORREO: " runat="server" />
            <asp:TextBox ID="txtCorreo" runat="server" />
            <br />
            <br />
            <asp:Label Text="NUMERO DE CONTACTO: " runat="server" />
            <asp:TextBox ID="txtContacto" runat="server" />
            <br />
            <br />
            <asp:Label Text="CLAVE: " runat="server" />
            <asp:TextBox ID="TextBox7" runat="server" TextMode="Password" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Registrarse" OnClientClick="return validarCuenta()" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Volver" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="lblRespuesta" runat="server"></asp:Label>

        </form>
    </div>
</body>
</html>
