using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string _respuesta = "Usuario Registrado";
            Guardar();
            Limpiar();
            lblRespuesta.Text = _respuesta;
            
        }

        private void Limpiar()
        {
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
            this.TextBox4.Text = "";
            this.TextBox5.Text = "";
            this.TextBox6.Text = "";
            this.TextBox7.Text = "";

        }

        private void Guardar()
        {
            string _respuesta = lblRespuesta.Text;
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();
            USUARIO _registrar = new USUARIO();
            

            _registrar.RUTUSUARIO = TextBox1.Text;
            _registrar.NOMBREUSUARIO = TextBox2.Text;
            _registrar.APELLIDOPATERNOUSUARIO = TextBox3.Text;
            _registrar.APELLIDOMATERNOUSUARIO = TextBox4.Text;
            _registrar.CORREOUSUARIO = TextBox5.Text;
            _registrar.TELEFONOUSUARIO = Convert.ToInt32(TextBox6.Text);
            _registrar.CLAVEUSUARIO = TextBox7.Text;
            



            bdd.INSERTUSUARIO(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, Convert.ToInt32(TextBox6.Text), TextBox7.Text, 1, "1");
            try
            {
                bdd.SubmitChanges();
                _respuesta = "Usuario Registrado";
            }
            catch (Exception)
            {

                _respuesta = "Error al Registrar Usuario";
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }


    }
}