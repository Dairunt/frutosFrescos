<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sumarProductos.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.sumarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    
        <h1>SUMA DE PRODUCTOS</h1>
        PRODUCTO:&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        VALOR:&nbsp;
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        PRODUCTOR:&nbsp;
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <br />
        STOCK/Kg:&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
        <br />
        CANTIDAD ACTUAL:&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <br />
        CANTIDAD DE Kg QUE DESEA SUMAR:&nbsp;
        <asp:TextBox ID="txtCantidad" runat="server" Width="239px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAgregar" runat="server" OnClick="Button1_Click" Text="AGREGAR" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
