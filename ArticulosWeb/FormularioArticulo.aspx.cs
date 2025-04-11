using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArticulosWeb
{
	public partial class FormularioArticulo : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void btnAceptar_Click(object sender, EventArgs e)
		{

		}
		protected void txtImagenUrl_TextChanged(object sender, EventArgs e)
		{
            imgArticulo.ImageUrl = txtImagenUrl.Text;
		}
	}
}