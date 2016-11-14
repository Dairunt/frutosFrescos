using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class editarCuentaProductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            USUARIO _usuario = (USUARIO)Session["Usuario"];

            Label1.Text = _usuario.RUTUSUARIO;
            Label2.Text = _usuario.NOMBREUSUARIO;
            Label3.Text = _usuario.APELLIDOPATERNOUSUARIO;
            Label4.Text = _usuario.APELLIDOMATERNOUSUARIO;
            Label5.Text = _usuario.CORREOUSUARIO;
            Label6.Text = _usuario.TELEFONOUSUARIO.ToString();
            Label7.Text = _usuario.CLAVEUSUARIO;
        }

        protected void modificarFoto_Click(object sender, EventArgs e)
        {
            Response.Redirect("fotoPerfilProductor.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("cerrarCuentaProductor.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelProductor.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("cambiarContraseniaProductor.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("modificarProductor.aspx");
        }
    }
}