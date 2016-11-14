<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fotoPerfilProductor.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.fotoPerfilProductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrap">
        <h1>MODIFICAR FOTO DE PERFIL</h1>        
        <section>
            <img src="#" alt="Cambiar Foto" />
        </section>            
        <asp:Button ID="btnCambiarFoto" runat="server" Text="Cambiar Foto" />
        &nbsp;&nbsp;
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    </div>
    </form>
</body>
</html>
