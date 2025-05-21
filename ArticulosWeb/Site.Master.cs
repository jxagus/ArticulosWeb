using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using NegocioArticulo;

namespace ArticulosWeb
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page is Login || Page is Registro || Page is Explorar || Page is Preguntas || Page is Error))
            {
                if (!Seguridad.sesionActiva(Session["usuario"]))
                    Response.Redirect("Login.aspx", false);
            }
            if (Seguridad.sesionActiva(Session["usuario"]))
                imgAvatar.ImageUrl = "~/Img/Perfil" + ((Usuario)Session["usuario"]).ImagenPerfil;
            else
                imgAvatar.ImageUrl = "~/Img/usuarioDefault.jpg";
        }
        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}