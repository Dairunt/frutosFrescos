using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class verProductores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            //try
            //{
            //    Session["Usaurio"].ToString();
            GridView1.DataSource = bdd.SELECTPRODUCTORE2();
            GridView1.DataBind();
            //}
            //catch (Exception ex)
            //{
            //    Response.Redirect("login.aspx?Usuario={0}");
            //}
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            Buscarr();
        }

        private void Buscarr()
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();


            string _respuesta = txtBuscar.Text;

            if (RadioButton1.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTPRODUCTORESNOMBRE(_respuesta);
                GridView1.DataBind();
            }
            else if (RadioButton2.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTPRODUCTORESCOMUNA(_respuesta);
                GridView1.DataBind();
            }
            else if (RadioButton3.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTPRODUCTORESPROVINCIA(_respuesta);
                GridView1.DataBind();
            }
            else if (RadioButton4.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTPRODUCTORESREGION(_respuesta);
                GridView1.DataBind();
            }
            else
            {
                Label1.Text = "Productor no existe.";
            }
        }

        protected void btnVolverP_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelUsuario.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gr_Seleccionar(object sender, GridViewSelectEventArgs e)
        {
            string rut = GridView1.DataKeys[e.NewSelectedIndex].Value.ToString();
            Response.Redirect(string.Format("informacionProductorProductos.aspx?rut={0}", rut));
        }
    }
}