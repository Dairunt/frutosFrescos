<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarAlCarro.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.agregarAlCarro" %>

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
        <h1>Agregar Producto al Carrito</h1>
        <form id="form1" runat="server" onsubmit="return validarDatos()">
            Nombre: <asp:Label Text="" ID="Label1" runat="server" />
            <br />
            <br />
            Valor: <asp:Label Text="" ID="Label2" runat="server" />
            <br />
            <br />
            Productor: <asp:Label Text="" ID="Label3" runat="server" />
            <br />
            <br />
            Stock / Kg: <asp:Label Text="" ID="Label5" runat="server" />
            <br />
            <br />
            <br />
            <br />
            <asp:Label Text="Ingrese Cantidad Desea: " runat="server" />
            <asp:TextBox ID="txtCarrito" runat="server" />
            <br />
            <asp:Button ID="ButtonCarrito" Text="Agregar" runat="server" OnClientClick="return validarDatos()" OnClick="ButtonCarrito_Click" />
        </form>
    </div>
</body>
</html>
