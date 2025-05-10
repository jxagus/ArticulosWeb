using System;
using System.Web.UI;
using Dominio;
using NegocioArticulo;

namespace ArticulosWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Dominio.Usuario usuario;
            UsuarioNegocio negocio = new UsuarioNegocio();

            try
            {
                usuario = new Dominio.Usuario(txtUser.Text, txtPassword.Text, false);
                if (negocio.Loguear(usuario))
                {
                    Session.Add("usuario", usuario);
                    Response.Redirect("MenuLogin1Ejemplo.aspx", false);
                }
                else
                {
                    Session.Add("error", "user o pass incorrectos");
                    Response.Redirect("Error.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
    }
}
