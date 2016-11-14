using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class panelUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            //try
            //{
            USUARIO _usuario = (USUARIO)Session["Usuario"];

            //    if (_usuario.TIPOUSUARIO == 1)
            //    {
            Label1.Text = _usuario.NOMBREUSUARIO;

            //    }
            //    else
            //    {
            //        Response.Redirect("login.aspx?Usuario={0}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("editarCuenta.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("verProductores.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("verProductos.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("carritoCompra.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("historialCompras.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //Session.Remove("Usuario");
            Response.Redirect("login.aspx");
        }
    }
}