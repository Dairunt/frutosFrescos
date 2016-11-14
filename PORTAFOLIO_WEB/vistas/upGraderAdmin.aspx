<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upGraderAdmin.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.upGraderAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="height: 5px">UPGRADE CUENTA</h1>
    <div>
    
        INGRESAR RUT:
        <asp:TextBox ID="txtIngresar" runat="server" Width="200px" style="height: 22px"></asp:TextBox>
    
        &nbsp;&nbsp;
    
        <asp:Button ID="btnBuscar" runat="server" Text="BUSCAR" />
    
        <br />
        <br />
        ID:
        <asp:TextBox ID="txtIngresar0" runat="server" Width="200px" style="height: 22px"></asp:TextBox>
    
        <br />
        RUT:
        <asp:TextBox ID="txtIngresar1" runat="server" Width="200px" style="height: 22px"></asp:TextBox>
    
        <br />
        NOMBRE:
        <asp:TextBox ID="txtIngresar2" runat="server" Width="200px" style="height: 22px"></asp:TextBox>
    
        <br />
        APELLIDO PATERNO:
        <asp:TextBox ID="txtIngresar3" runat="server" Width="200px" style="height: 22px"></asp:TextBox>
    
        <br />
        APELLIDO MATERNO:
        <asp:TextBox ID="txtIngresar4" runat="server" Width="200px" style="height: 22px"></asp:TextBox>
    
        <br />
        TIPO USUARIO:
        <asp:TextBox ID="txtIngresar5" runat="server" Width="200px" style="height: 22px"></asp:TextBox>
    
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="UPGRADE" />
    
    &nbsp;
        <asp:Button ID="Button2" runat="server" Text="VOLVER" OnClick="Button2_Click" />
    
    </div>
    </form>
</body>
</html>
