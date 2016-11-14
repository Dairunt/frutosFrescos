<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detalleBoleta.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.detalleBoleta" %>

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
    
            <h1>DETALLE BOLETA</h1>
            <asp:Label Text="N° BOLETA: " runat="server" />
            <asp:TextBox runat="server" ID="txtnumerob"  />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label Text="FECEHA: " runat="server" />
            <asp:TextBox runat="server" ID="txtFecha"  />
            &nbsp;&nbsp;&nbsp;
            <asp:Label Text="RUT CLIENTE: " runat="server" />
            <asp:TextBox runat="server" ID="txtRutC"  />
            &nbsp;
            <asp:Label Text="VALOR: " runat="server" />
            <asp:TextBox runat="server" ID="txtValor"  />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBuscarD" runat="server" OnClick="Button2_Click" Text="BUSCAR" />
            &nbsp;&nbsp;
            <asp:Button ID="btnVolverD" runat="server" OnClick="Button1_Click" Text="VOLVER" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
    
        </div>
        </form>

    </div>
</body>
</html>
