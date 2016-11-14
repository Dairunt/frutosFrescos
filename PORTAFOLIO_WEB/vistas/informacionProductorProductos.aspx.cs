using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class informacionProductorProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            string rut = Context.Request.Params["rut"];
            

            var q = bdd.SELECTUSUARIOBYRUT(rut);

            foreach (var cadaConsulta in q)
            {
                
                Label1.Text = cadaConsulta.RUT;
                Label2.Text = cadaConsulta.NOMBRE;
                Label3.Text = cadaConsulta.APATERNO;
                Label4.Text = cadaConsulta.AMATERNO;
                Label5.Text = cadaConsulta.CORREO;
                Label6.Text = cadaConsulta.FONO.ToString();
                Label7.Text = cadaConsulta.COMUNA;
                Label8.Text = cadaConsulta.PROVINCIA;
                Label9.Text = cadaConsulta.REGION;
                Label10.Text = cadaConsulta.DESCRIPCION;
            }

        }

        protected void btnInformacion_Click(object sender, EventArgs e)
        {
            Informacion();
        }

        private void Informacion()
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            string rut = Context.Request.Params["rut"];
            var q = bdd.MISPRODUCTO(rut);

            GridView1.DataSource = q;
            GridView1.DataBind();
        }

        protected void grAgregar(object sender, GridViewSelectEventArgs e)
        {
            string rut = Context.Request.Params["rut"];
            string codProducto = GridView1.DataKeys[e.NewSelectedIndex].Value.ToString();
            Response.Redirect(string.Format("agregarAlCarrito.aspx?codProducto={0}&rut={1}", codProducto, rut));
        }
    }
}