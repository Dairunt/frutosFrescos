using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class upGraderAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Response.Redirect("login.aspx?Usuario={0}");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelAdministrador.aspx");
        }
    }
}