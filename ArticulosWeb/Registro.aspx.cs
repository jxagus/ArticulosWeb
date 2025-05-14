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
                usuario.User = txtUser.Text;
                usuario.Pass = txtPass.Text;
                int id = usuarioNegocio.insertarNuevo(usuario);
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
            }
        }
    }
}
