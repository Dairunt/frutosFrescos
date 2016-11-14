<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="panelProductor.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.panelProductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>
</head>
<body><div class="wrap">
        <form id="form1" runat="server">
        <div style="height: 543px">
    
            <h1>PANEL PRODUCTOR</h1>
            <br />
            <br />
            <asp:Label Text="BIENVENIDO" runat="server" ID="Label1" />
            <asp:Label Text="" runat="server" ID="Label2" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnEditarCuenta" runat="server" OnClick="Button1_Click" Text="Editar Cuenta" />
            &nbsp;
            <asp:Button ID="btnProductos" runat="server" Text="Productos" OnClick="Button3_Click" />
            &nbsp;
            <asp:Button ID="btnMisProductos" runat="server" Text="Mis Productos" OnClick="Button4_Click" />
            &nbsp;
            <asp:Button ID="btnHistorial" runat="server" Text="Historial de Ventas" OnClick="Button5_Click" />
            &nbsp;
            <asp:Button ID="btnCerrar" runat="server" Text="Cerrar Sesion" OnClick="Button6_Click" />
    
        </div>
        </form>
    </div>
</body>
</html>
