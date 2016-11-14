<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="informacionProductor.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.informacionProductor" %>

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
    
        <h1>INFORMACION PRODUCTOR</h1>
        RUT:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        NOMBRE:&nbsp;
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        APELLIDO PATERNO:&nbsp;
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <br />
        APELLIDO MATERNO:&nbsp;
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
        <br />
        CORREO:&nbsp;
        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <br />
        TELEFONO:&nbsp;
        <asp:Label ID="Label6" runat="server"></asp:Label>
        <br />
        <br />
        COMUNA:&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server"></asp:Label>
        <br />
        <br />
        PROVINCIA:&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server"></asp:Label>
        <br />
        <br />
        REGION:&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server"></asp:Label>
        <br />
        <br />
        DESCRIPCION:&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="VER PRODUCTOS" Width="219px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="VOLVER" />
        <br />
    
    </div>
    </form>
</body>
</html>
