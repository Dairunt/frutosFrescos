using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class agregarAlCarro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            string rut = Context.Request.Params["rut"];
            string codProducto = Context.Request.Params["codProducto"];

            var q = bdd.SELECTAGREGARALCARRO(rut, Convert.ToInt32(codProducto));

            foreach (var cadaConsulta in q)
            {
                Label1.Text = cadaConsulta.NOMBRE;
                Label2.Text = cadaConsulta.VALOR.ToString();
                Label3.Text = cadaConsulta.RUT;
                Label5.Text = cadaConsulta.STOCK.ToString();
            }
        }

        protected void ButtonCarrito_Click(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            USUARIO _usuario = (USUARIO)Session["Usuario"];

            DETALLEDOC _detalle = new DETALLEDOC();

            string rut = Context.Request.Params["rut"];
            string codProducto = Context.Request.Params["codProducto"];

            int _cantidad = Convert.ToInt32(txtCarrito.Text);
            int _idBoleta = 0;
            int _valorProd = 0;
            int _codigoProd = Convert.ToInt32(codProducto);
            int _idProductor = 0;

            var q = bdd.BUSCARVALORPRODUCTO(_codigoProd);
            foreach (var cadaConsulta in q)
            {
                _valorProd = Convert.ToInt32( cadaConsulta.VALORPRODUCTO);
            }

            var w = bdd.BUSCARIDCARRITO(_usuario.IDUSUARIO.ToString());
            foreach (var cadaConsulta in w)
            {
                _idBoleta = Convert.ToInt32( cadaConsulta.IDDOCUMENTO);
            }

            var p = bdd.BUSCARIDPRODUCTORPORRUT(rut);
            foreach (var cadaConsulta in p)
            {
                _idProductor = Convert.ToInt32(cadaConsulta.IDUSUARIO);
            }          


            if (txtCarrito.Text != "")
            {
                _detalle.CANTIDADPEDIDODETALLEDOC = _cantidad;
                _detalle.VALORPRODDETALLEDOC = Convert.ToInt32( _valorProd);
                _detalle.SUBTOTALPRODUCTODETALLEDOC = Convert.ToInt32(_valorProd * _cantidad);
                _detalle.DOCUMENTOIDDOCUMENTO = Convert.ToInt32(_idBoleta);
                _detalle.PRODUCTOIDPRODUCTO = Convert.ToInt32(_idProductor);
                _detalle.USUARIOIDUSUARIO = _usuario.IDUSUARIO;

                bdd.AGREGARALCARRO(_cantidad, _valorProd, _idBoleta, _codigoProd, _idProductor);
                try
                {
                    bdd.SubmitChanges();
                    Response.Redirect("carritoCompra.aspx");
                }
                catch (Exception)
                {

                    throw;
                }

            }
            
        }
    }
}