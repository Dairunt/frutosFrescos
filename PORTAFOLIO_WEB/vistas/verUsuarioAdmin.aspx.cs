using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class verUsuarioAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            try
            {
                GridView1.DataSource = bdd.SELECTUSUARIOSADM();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect("login.aspx?Usuario={0}");
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrarr();
        }

        private void Filtrarr()
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();


            string _respuesta = txtBuscar.Text;

            if (RadioButton1.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTUSUARIOSADMRUT(_respuesta);
                GridView1.DataBind();
            }
            else if (RadioButton2.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTUSUARIOSADMCOMUNA(_respuesta);
                GridView1.DataBind();
            }
            else if (RadioButton3.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTUSUARIOSADMPROVINCIA(_respuesta);
                GridView1.DataBind();
            }
            else if (RadioButton4.Checked == true)
            {
                GridView1.DataSource = bdd.SELECTUSUARIOSADMREGION(_respuesta);
                GridView1.DataBind();
            }
        }

        protected void btnVolverP_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelAdministrador");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("eliminarUsuario.aspx");
        }
    }
}