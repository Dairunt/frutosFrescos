<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productorPorProducto.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.productorPorProducto" %>

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
    
        <h1>PRODUCTOR POR PRODUCTO</h1>
        NOMBRE:&nbsp;
        <asp:TextBox runat="server" ID="txtNombreP" Width="147px"/>
        <br />
        <br />
        VALOR:&nbsp;
        <asp:TextBox runat="server" ID="txtValor" Width="159px"/>
        <br />
        <br />
        DESCRIPCION:&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="txtDes" Width="144px"/>
        <br />
        <br />
    
        <asp:Button ID="btnBuscar" runat="server" Text="BUSCAR" OnClick="btnBuscar_Click" />
    
        &nbsp;
    
        <asp:Button ID="btnVolverP" runat="server" Text="VOLVER" />
    
        <br />
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="rut" OnSelectedIndexChanging="Seleccionar">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
