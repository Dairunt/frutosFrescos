using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class verProductosProdAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            try
            {
                GridView1.DataSource = bdd.SELECTPRODUCTOSADM();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect("login.aspx?Usuario={0}");
            }
        }

        protected void btnVolverF_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelAdministrador.aspx");
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
            //PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            //string _producto = txtFiltrar.Text;

            //if (_producto != "")
            //{
            //    GridView1.DataSource = bdd.SELECTPRODUCTOSADMNOMBRE1(_producto);
            //    GridView1.DataBind();
            //}
            //else
            //{
            //    Label1.Text = "El producto no existe";
            //}
        }
    }
}