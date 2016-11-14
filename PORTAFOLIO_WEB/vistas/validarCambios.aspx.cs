using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class validarCambios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {

        }

        private void limpiarCampos()
        {
            this.txtCambio.Text = "";
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelUsuario.aspx");
        }


    }
}