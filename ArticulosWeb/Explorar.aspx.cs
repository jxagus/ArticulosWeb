using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegocioArticulo;

namespace ArticulosWeb
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio Articulos = new Negocio();
            dgvArticulos.DataSource = Articulos.listarConSP();
            dgvArticulos.DataBind(); //Enlace los datos
        }
    }
}