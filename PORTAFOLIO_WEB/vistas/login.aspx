<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>
</head>
<body>
    <div class="wrap">
        <form id="form1" runat="server" method="get">
        <h1>Ingrese a Su Cuentra</h1>
            <asp:Label Text="RUT: " runat="server" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label Text="CLAVE: " runat="server" />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Ingresar" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="Registrarse" OnClick="Button2_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
        </form>
    </div>
</body>
</html>
