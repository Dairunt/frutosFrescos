<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verProductosProdAdmin.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.verProductosProdAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>VER PRODUCTOS PROD</h1>
    <div>
    
        FILTRAR POR NOMBRE:
        <asp:TextBox ID="txtFiltrar" runat="server" Width="240px"></asp:TextBox>
    
        &nbsp;
    
        <asp:Button ID="btnFiltrar" runat="server" Text="FILTRAR" OnClick="btnFiltrar_Click" />
    
    &nbsp;
    
        <asp:Button ID="btnVolverF" runat="server" Text="VOLVER" OnClick="btnVolverF_Click" />
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnAgregar" runat="server" Text="AGREGAR PRODUCTO" />
        &nbsp;
        <asp:Button ID="btnCambiar" runat="server" Text="CAMBIAR ESTADO DE PRODUCTO" />
        &nbsp;
        <asp:Button ID="btnEditar" runat="server" Text="EDITAR PRODUCTO" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
