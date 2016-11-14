using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class verProductoresAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            try
            {
                GridView1.DataSource = bdd.SELECTPRODUCTORESADM();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect("login.aspx?Usuario={0}");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("eliminarProductor.aspx");
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();


            string _respuesta = txtBuscar.Text;

            if (RadioButton1.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTPRODUCTORESADMRUT(_respuesta);
                GridView1.DataBind();
            }
            else if (RadioButton2.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTPRODUCTORESADMCOMUNA(_respuesta);
                GridView1.DataBind();
            }
            else if (RadioButton3.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTPRODUCTORESADMPROVINCIA(_respuesta);
                GridView1.DataBind();
            }
            else if (RadioButton4.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTPRODUCTORESADMREGION(_respuesta);
                GridView1.DataBind();
            }
        }

        protected void btnVolverP_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelAdministrador.aspx");
        }
    }
}