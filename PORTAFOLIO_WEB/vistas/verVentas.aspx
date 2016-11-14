<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verVentas.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.verVentas" %>

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
    
            <h1>VER VENTAS</h1> 
            <asp:RadioButton ID="rbtFiltrarF" runat="server" Text="FILTRAR POR FECHA" GroupName="grRadio" ToolTip="fecha" />
            &nbsp;&nbsp;
            <asp:TextBox ID="txtFEcha" runat="server" Width="166px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" Text="FILTRAR POR N* BOLETA" GroupName="grRadio" ToolTip="boleta"/>
            &nbsp;
            <asp:TextBox ID="txtBoleta" runat="server" Width="166px"></asp:TextBox>
            &nbsp;&nbsp;<asp:Button ID="btnBuscar" runat="server" Text="BUSCAR" OnClick="btnBuscar_Click" />
&nbsp;<asp:Button ID="btnVolverH" runat="server" OnClick="Button1_Click" Text="VOLVER" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
    
        </div>
        </form>

    </div>
</body>
</html>
