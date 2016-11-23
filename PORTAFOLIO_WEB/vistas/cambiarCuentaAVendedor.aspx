<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cambiarCuentaAVendedor.aspx.cs" Inherits="PORTAFOLIO_WEB.vistas.cambiarCuentaAVendedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Style.css" rel="stylesheet" />
    <title>PORTAFOLIO</title>   
<script type="text/javascript" src="vistas/JS/validarDatos.js"></script>
</head>
<body>
    <form id="form1" runat="server" method="POST" onsubmit="return validarDatos()">
        <h1>Enviar Correo Para Cambiar De Perfil</h1>
        <div>
            <div>
            <label class="label" for="para">Para: </label>
            <input type="text" id="txtPara" name="Para" disabled="disabled" value="carlos.leiva90@gmail.com" runat="server"/>
            </div>
            <div>
            <label class="label" for="fono">CC: </label>
            <input type="text" id="txtCC" name="CC"/>
            </div>
            <div>
            <label class="label" for="asunto">Asunto: </label>
            <input type="text" id="txtAsunto" name="asunto" disabled="disabled" value="Cambiar a Vendedor"/>
            </div>
            <div>
            <label class="label" for="comentario">Comentario: </label>
            <textarea name="comentario" id="txtComentario" cols="30" rows="10""></textarea>
            </div>
            
            <div>
            <input type="checkbox" id="cbxTerminos" name="terminos" value="true"/>
            <label for="terminos">Seguro que desea enviar este mensaje?</label>
            </div>            
        </div>
        <asp:Button ID="Button1" runat="server" onClientClick="return validarMensaje()" Text="Enviar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Volver" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Label ID="lblRespuesta" runat="server"></asp:Label>
    </form>
</body>
</html>
