using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class historialVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            try
            {
                
                var q = from a in bdd.DOCUMENTOs
                        select a;

                GridView1.DataSource = q;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect("login.aspx?Usuario={0}");
            }
        }

        protected void txtBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();


            string _respuesta = txtBoleta.Text;
            string _resp = txtFEcha.Text;

            if (rbtFiltrarF.Checked == true)
            {
                GridView1.DataSource = bdd.BUSCARDETALLEPORID(Convert.ToInt32(_resp));
                GridView1.DataBind();
            }
            else if (RadioButton2.Checked == true)
            {
                GridView1.DataSource = bdd.BUSCARBOLETAPORID(Convert.ToInt32(_respuesta));
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}