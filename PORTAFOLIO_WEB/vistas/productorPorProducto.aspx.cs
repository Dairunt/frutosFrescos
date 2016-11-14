using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class productorPorProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            string id = Context.Request.Params["id"];

            var q = bdd.SELECTPRODUCTORPORPRODUCTO2(Convert.ToInt32(id));

            GridView1.DataSource = q;
            GridView1.DataBind();
        }

        protected void Seleccionar(object sender, GridViewSelectEventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            string rut = GridView1.DataKeys[e.NewSelectedIndex].Value.ToString();
            string codProducto = Context.Request.Params["id"];
            Response.Redirect(string.Format("agregarAlCarrito.aspx?rut={0}&codProducto={1}", rut, codProducto));
        }
    }
}