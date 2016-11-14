using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class verProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            
                GridView1.DataSource = bdd.SELECTPRODUCTO2();
                GridView1.DataBind();
            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelUsuario.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {

            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            string _respuesta = txtFiltarN.Text;

            if (txtFiltarN.Text != null)
            {
                GridView1.DataSource = bdd.SELECTPRODUCTOSNOMBRE(_respuesta);
                GridView1.DataBind();
            }
            else
            {
                Label1.Text = "El producto no existe";
            }

        }

        protected void grSeleccionar(object sender, GridViewSelectEventArgs e)
        {
            string id = GridView1.DataKeys[e.NewSelectedIndex].Value.ToString();
            Response.Redirect(string.Format("productorPorProducto.aspx?id={0}", id));
        }
    }
}