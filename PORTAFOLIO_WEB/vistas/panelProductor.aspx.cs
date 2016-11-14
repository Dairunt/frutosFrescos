using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class panelProductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            //try
            //{
            USUARIO _usuario = (USUARIO)Session["Usuario"];

            Label2.Text = _usuario.NOMBREUSUARIO;
            //}
            //catch (Exception ex)
            //{
            //    Response.Redirect("login.aspx?Usuario={0}");
            //}
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("editarCuentaProductor.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("verProductos.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("historialVentas.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("misProductos.aspx");
        }
    }
}