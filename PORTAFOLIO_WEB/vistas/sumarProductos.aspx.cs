using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class sumarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            USUARIO _usuario = (USUARIO)Session["Usuario"];
            int carrito = 0;
            string rutPro = "0";
            string codPedido = Context.Request.Params["codPedido"];

            var q = bdd.BUSCARIDCARRITO(_usuario.IDUSUARIO.ToString());         
            foreach (var cadaConsulta in q)
            {
                carrito = Convert.ToInt32(cadaConsulta.IDDOCUMENTO);
            }

            var p = bdd.BUSCARRUTPORCODPEDIDO(Convert.ToInt32(codPedido));
            foreach (var cadaConsulta in p)
            {
                rutPro = cadaConsulta.RUTUSUARIO;
            }

            var c = bdd.SELECTUPDATECARRO(Convert.ToInt32(codPedido), carrito);
            foreach (var cadaConsulata in c)
            {
                Label1.Text = cadaConsulata.NOMBREPRODUCTO;
                Label2.Text = cadaConsulata.VALORPRODUCTO.ToString();
                Label3.Text = rutPro;
                Label4.Text = cadaConsulata.STOCKPRODUCTOPRODUCTOR.ToString();
                Label5.Text = cadaConsulata.CANTIDADPEDIDODETALLEDOC.ToString();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            string cod = Context.Request.Params["cod"];
            bdd.CARRITOSUMAR(Convert.ToInt32(cod), Convert.ToInt32( txtCantidad.Text));
            bdd.SubmitChanges();
            Response.Redirect("carritoCompra.aspx");
        }
        
    }
}