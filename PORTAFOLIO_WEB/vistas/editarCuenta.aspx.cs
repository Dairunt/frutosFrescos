using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class editarCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            try
            {
                USUARIO _usuario = (USUARIO)Session["Usuario"];

                Label1.Text = _usuario.RUTUSUARIO;
                Label2.Text = _usuario.NOMBREUSUARIO;
                Label3.Text = _usuario.APELLIDOPATERNOUSUARIO;
                Label4.Text = _usuario.APELLIDOMATERNOUSUARIO;
                Label5.Text = _usuario.CORREOUSUARIO;
                Label6.Text = _usuario.TELEFONOUSUARIO.ToString();
                Label7.Text = _usuario.CLAVEUSUARIO;
            }
            catch (Exception ex)
            {
                Response.Redirect("login.aspx?Usuario={0}");
            }
        }

        protected void modificarFoto_Click(object sender, EventArgs e)
        {
            Response.Redirect("fotoPerfil.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("cambiarCuentaAVendedor.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("cerrarCuenta.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelUsuario.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("cambiarContrasenia.aspx");

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("modificarUsuario.aspx");
        }
    }
}