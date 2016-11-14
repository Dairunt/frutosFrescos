using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class panelAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            //try
            //{
            USUARIO _usuario = (USUARIO)Session["Usuario"];

            Label1.Text = _usuario.NOMBREUSUARIO;
            //}
            //catch (Exception ex)
            //{
            //    Response.Redirect("login.aspx?Usuario={0}");
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("verUsuarioAdmin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("verProductoresAdmin.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("verProductosProdAdmin.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("upGraderAdmin.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("verVentas.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Session.Remove("Usuario");
            Response.Redirect("login.aspx");
        }
    }
}