using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PORTAFOLIOContext;

namespace PORTAFOLIO_WEB.vistas
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.Params["Usuario"] != 0.ToString())
            //{
            //    string _usuario = Request.Params["Usuario"];

            //    if (_usuario == "1")
            //    {
            //        Label1.Text = "Debe Iniciar Sesión";
            //    }

            //}

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Ingresar();
        }

        private void Ingresar()
        {
            PORTAFOLIODataContext bdd = new PORTAFOLIODataContext();

            USUARIO _usuario = new USUARIO();

            string rut = TextBox1.Text;
            string clave = TextBox2.Text;

            bdd.LOGIN(rut, clave);
            var q = from a in bdd.USUARIOs
                    where a.RUTUSUARIO == rut
                    select a;

            foreach (var consultaUsuario in q)
            {
                string a = consultaUsuario.RUTUSUARIO;
                string b = consultaUsuario.CLAVEUSUARIO;

                if (rut == a )
                {
                    if (clave == b)
                    {
                        _usuario.IDUSUARIO = consultaUsuario.IDUSUARIO;
                        _usuario.NOMBREUSUARIO = consultaUsuario.NOMBREUSUARIO;
                        _usuario.RUTUSUARIO = consultaUsuario.RUTUSUARIO;
                        _usuario.APELLIDOMATERNOUSUARIO = consultaUsuario.APELLIDOMATERNOUSUARIO;
                        _usuario.APELLIDOPATERNOUSUARIO = consultaUsuario.APELLIDOPATERNOUSUARIO;
                        _usuario.CORREOUSUARIO = consultaUsuario.CORREOUSUARIO;
                        _usuario.TELEFONOUSUARIO = consultaUsuario.TELEFONOUSUARIO;
                        _usuario.DESCRIPCIONUSUARIO = consultaUsuario.DESCRIPCIONUSUARIO;
                        _usuario.CLAVEUSUARIO = consultaUsuario.CLAVEUSUARIO;
                        _usuario.TIPOUSUARIO = consultaUsuario.TIPOUSUARIO;
                        _usuario.ESTADOUSUARIO = consultaUsuario.ESTADOUSUARIO;
                        _usuario.FOTOUSUARIO = consultaUsuario.FOTOUSUARIO;

                        Session["Usuario"] = _usuario;

                        int c = Convert.ToInt32(consultaUsuario.TIPOUSUARIO);
                        if (c == 1)
                        {
                            Response.Redirect("panelUsuario.aspx");
                        }
                        else if (c == 2)
                        {
                            Response.Redirect("panelProductor.aspx");
                        }
                        else if (c == 3)
                        {
                            Response.Redirect("panelAdministrador.aspx");
                        }
                    }
                    else
                    {
                        Label1.Text = "Error De Contraseña";
                    }
                }
                else
                {
                    Label1.Text = "Error de Rut";
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("registar.aspx");
        }
    }
}