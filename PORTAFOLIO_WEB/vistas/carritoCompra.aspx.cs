using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class carritoCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            try
            {
                USUARIO _usuario = (USUARIO)Session["Usuario"];
                int id = Convert.ToInt32(_usuario.IDUSUARIO);
                int cod_boleta = 0;

                var q = from a in bdd.DOCUMENTOs
                        where a.USUARIOIDUSUARIO == id
                        && a.ESTADODOCUMENTO == "1" &&
                        a.TIPOODOCUMENTO == 0
                        select a;
                

                foreach (var consulta in q)
                {
                    cod_boleta = Convert.ToInt32(consulta.IDDOCUMENTO);
                }

                GridView1.DataSource = bdd.CARRITODECOMPRA(cod_boleta);
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect("login.aspx?Usuario={0}");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelUsuario.aspx");
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Comprar();
        }

        private void Comprar()
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            string _respuesta = txtCCarrito.Text;

            GridView1.DataSource = bdd.LISTARDETALLEPORBOLETA(Convert.ToInt32(_respuesta));
            GridView1.DataBind();
        }

        protected void Eliminar(object sender, GridViewSelectEventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            string cod = GridView1.DataKeys[e.NewSelectedIndex].Value.ToString();
            bdd.CARRITOELIMINAR(Convert.ToInt32(cod));
            bdd.SubmitChanges();
            Response.Redirect("carritoCompra.aspx");
        }

        protected void Sumar(object sender, GridViewEditEventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            string codPedido = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
            Response.Redirect(string.Format("sumarProductos.aspx?codPedido={0}", codPedido));
        }

        protected void Restar(object sender, GridViewDeletedEventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            string sumar = GridView1.DataKeys[e.AffectedRows].Value.ToString();
            Response.Redirect("restarProducto.aspx");
        }
    }
}