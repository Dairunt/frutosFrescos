<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="carritoCompra.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.carritoCompra" %>

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
            <h1>Carrito de Compras</h1>
            FILTRAR POR ID:
            <asp:TextBox ID="txtCCarrito" runat="server"></asp:TextBox>
            <asp:Button ID="btnComprar" runat="server" Text="COMPRAR" OnClick="btnComprar_Click" />
            &nbsp;
            <asp:Button ID="btnVolverCC" runat="server" OnClick="Button2_Click" Text="VOLVER" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="codPedido" OnSelectedIndexChanging="Eliminar" OnRowDeleted="Restar" OnRowEditing="Sumar" Width="388px" >
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="Eliminar" ShowSelectButton="True" />
                    <asp:CommandField ButtonType="Button" EditText="Sumar" ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
    
        </div>
        </form>

    </div>
</body>
</html>
