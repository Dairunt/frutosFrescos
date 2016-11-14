<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verProductosProductor.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.verProductosProductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>VER PRODUCTOS</h1>
        FILTRAR POR NOMBRE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFiltarN" runat="server" Width="359px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnBuscar" runat="server" OnClick="Button2_Click" Text="BUSCAR" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnVolverV" runat="server" OnClick="Button1_Click" Text="VOLVER" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="codproducto" OnSelectedIndexChanging="grSeleccionar">
            <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Seleccionar Producto" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
    </form>
</body>
</html>
