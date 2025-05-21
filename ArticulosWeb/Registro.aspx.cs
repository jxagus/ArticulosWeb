using System;
using System.Web.UI;
using Dominio;
using NegocioArticulo;

namespace ArticulosWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Dominio.Usuario usuario = new Dominio.Usuario();
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                EmailService emailService = new EmailService();

                usuario.Email = txtEmail.Text;
                usuario.Pass = txtPass.Text;
                usuario.Id = usuarioNegocio.insertarNuevo(usuario);
                Session.Add("usuario", usuario); //guardo el usuario en la sesion

                emailService.armarCorreo(usuario.Email,"Bienvenidos a ArticulosWeb","te damos la bienvenida"); //mensajito por registrarte
                emailService.enviarEmail();
                Response.Redirect("Default", false); //redirecciono a login
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
            }
        }
    }
}
