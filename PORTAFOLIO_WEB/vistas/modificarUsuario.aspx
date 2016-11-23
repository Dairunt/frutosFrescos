<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificarUsuario.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.modificarUsuario" %>

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
        <form id="form1" runat="server">
        <div>
    
            <h1>DATOS PERSONALES</h1>
            <div>
                RUT :
                <asp:TextBox ID="txtRut" runat="server" Enabled="false"></asp:TextBox>            
            </div> 
            <div> 
                NOMBRE:
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>
            <div> 
                APELLIDO PATERNO:
                <asp:TextBox ID="txtApellidoP" runat="server" ></asp:TextBox>
            </div>
            <div>
                APELLIDO MATERNO:
                <asp:TextBox ID="txtApellidoM" runat="server" ></asp:TextBox>
            </div> 
                <div>CORREO:
                <asp:TextBox ID="txtCorreo" runat="server" Enabled="false"></asp:TextBox>
            </div>             

            <div> 
                NUMERO DE CONTACTO:
                <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
            </div>
            <br />
            <br />
            <asp:Button ID="btnAceptar" runat="server" OnClientClick="return validarCuenta()" OnClick="Button1_Click" Text="ACEPTAR" Width="107px" />
            &nbsp;
            <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" OnClick="Button2_Click" Width="128px" />
    
        </div>
        </form>

    </div>
</body>
</html>
