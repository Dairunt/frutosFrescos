<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="misProductos.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.misProductos" %>

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
        <h1>Mis Productos</h1>

        BUSCAR POR:&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton1" runat="server" Text="NOMBRE" />
&nbsp;
        <asp:TextBox ID="txtBuscar" runat="server" Width="195px"></asp:TextBox>
        &nbsp;
        <asp:Button ID="Button3" runat="server" Text="Filtrar" />
        &nbsp;
        <asp:Button ID="btnVolverP" runat="server" Text="Volver" OnClick="Button2_Click" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    &nbsp;
        
    </div>
    </form>
</body>
</html>
