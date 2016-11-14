using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class detalleBoleta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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


            string _respuesta = txtnumerob.Text;
            string _resp = txtFecha.Text;
            string _rp = txtRutC.Text;
            string _r = txtValor.Text;

            if (txtnumerob != null)
            {
                GridView1.DataSource = bdd.LISTARDETALLEPORBOLETA(Convert.ToInt32(_respuesta));
                GridView1.DataBind();
            }
            else if (txtFecha != null)
            {
                GridView1.DataSource = bdd.LISTARDETALLEPORBOLETA(Convert.ToInt32(_resp));
                GridView1.DataBind();
            }
            else if (txtRutC != null)
            {
                GridView1.DataSource = bdd.LISTARDETALLEPORBOLETA(Convert.ToInt32(_rp));
                GridView1.DataBind();
            }
            else if (txtValor != null)
            {
                GridView1.DataSource = bdd.LISTARDETALLEPORBOLETA(Convert.ToInt32(_r));
                GridView1.DataBind();
            }
        }
    }
}