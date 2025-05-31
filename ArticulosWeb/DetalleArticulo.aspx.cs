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
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        public Articulo ArticuloDetalle { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Leer el ID de la URL
                if (Request.QueryString["id"] != null && int.TryParse(Request.QueryString["id"], out int id))
                {
                // Buscar el artículo en la base de datos
                    Negocio negocio = new Negocio();
                    ArticuloDetalle = negocio.BuscarPorId(id);
                }
                else
                {
                    // Mostrar mensaje de error o redirigir
                    Response.Redirect("Default.aspx"); // o mostrar un cartel
                }
            }
        }
        public string ObtenerUrlImagen(object imagen)
        {
            string url = imagen?.ToString();
            if (string.IsNullOrEmpty(url) || !url.StartsWith("https"))
                return "Img/NoDisponible.jpg";
            return url;
        }
    }
}