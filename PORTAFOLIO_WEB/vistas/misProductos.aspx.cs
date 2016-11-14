using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class misProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            USUARIO _usuario = (USUARIO)Session["Usuario"];

            var q = bdd.MISPRODUCTO(_usuario.RUTUSUARIO);

            GridView1.DataSource = q;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelProductor.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Buscarr();
        }

        private void Buscarr()
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            string _respuesta = txtBuscar.Text;

            if (RadioButton1.Checked)
            {
                GridView1.DataSource = bdd.LISTARSTOCKPORPRODUCTOR(Convert.ToInt32(_respuesta));
            }
        }
    }
}