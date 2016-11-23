<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarCuenta.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.editarCuenta" %>

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
        <div style="height: 504px">
    
            <h1>Editar Cuenta</h1>
            <br />
            <asp:Label Text="Rut: " runat="server" />
            <asp:Label Text="" runat="server" ID="Label1"/>
            <br />
            <br />
            <asp:Label Text="Nombre: " runat="server" />
            <asp:Label Text="" runat="server" ID="Label2"/>
            <br />
            <br />
            <asp:Label Text="Apellido Paterno: " runat="server" />
            <asp:Label Text="" runat="server" ID="Label3"/>
            <br />
            <br />
            <asp:Label Text="Apellido Materno: " runat="server" />
            <asp:Label Text="" runat="server" ID="Label4"/>
            <br />
            <br />
            <asp:Label Text="Correo: " runat="server" />
            <asp:Label Text="" runat="server" ID="Label5"/>
            <br />
            <br />
            <asp:Label Text="Numero de Contacto: " runat="server" />
            <asp:Label Text="" runat="server" ID="Label6"/>
            <br />
            <br />
            <asp:Label Text="Contraseña: " runat="server" />
            <asp:Label Text="" runat="server" ID="Label7"/>           
            <br />
            <br />
            <br />
            <asp:Button ID="btnModificarFoto" runat="server" Text="Modificar Foto de Perfil" OnClick="modificarFoto_Click" />
            &nbsp;
            <asp:Button ID="btnCambiarCuenta" runat="server" OnClick="Button2_Click" Text="Cambiar Cuenta a Vendedor" />
            &nbsp;
            <asp:Button ID="btnCerrarCuenta" runat="server" Text="Cerrar Cuenta" OnClick="Button3_Click" />
            &nbsp;
            <asp:Button ID="btnPanelPrincipal" runat="server" OnClick="Button4_Click" Text="Panel Principal" />
            &nbsp;
            <asp:Button ID="btnModificarContrasenia" runat="server" Text="Modificar Contraseña" Width="199px" OnClick="Button5_Click" />
            &nbsp;
            <asp:Button ID="btnModificarDatos" runat="server" OnClientClick="return validarCuenta()" OnClick="Button6_Click" Text="Modificar Datos Personales" />
        </div>
        </form>
    </div>
</body>
</html>
