using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegocioArticulo;

namespace ArticulosWeb
{
	public partial class Lista : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Negocio articulo = new Negocio();
			dgvLista.DataSource = articulo.listarConSP();
			dgvLista.DataBind();
		}
		protected void DgvLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			dgvLista.PageIndex = e.NewPageIndex;
			dgvLista.DataBind();
		}
        protected void DgvLista_SelectedIndexChanged(object sender, EventArgs e)
		{
			string id = dgvLista.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioArticulo.aspx?id=" + id);
        }


    }
}