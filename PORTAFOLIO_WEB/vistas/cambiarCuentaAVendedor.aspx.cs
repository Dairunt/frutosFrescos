using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class cambiarCuentaAVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EnvioCorreo();
        }

        private void EnvioCorreo()
        {
            try
            {
                SmtpClient clientSMTP = new SmtpClient("smtp.gmail.com", 587);
                clientSMTP.EnableSsl = true;
                clientSMTP.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientSMTP.UseDefaultCredentials = false;
                clientSMTP.Credentials = new NetworkCredential("i.vasquezv7@gmail.com", "nashoactivao");
                using (MailMessage message = new MailMessage())
                {
                    message.From = new MailAddress("carlos.leiva90@gmail.com");
                    message.Subject = "Cambiar Cuenta";
                    message.IsBodyHtml = true;
                    message.To.Add(this.txtPara.Value.ToString());
                    message.Body = "Estimado, Su codigo de activacion es el siguiente: ";

                    clientSMTP.Send(message);
                }
            }
            catch (Exception)
            { }
            finally
            { }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("panelUsuario.aspx");
        }
    }
}