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
	public partial class FormularioArticulo : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				if (!IsPostBack) {

					Negocio negocio = new Negocio();
					List<Elemento> categorias = negocio.listarElementoDesdeTabla("Categorias");
					List<Elemento> marcas = negocio.listarElementoDesdeTabla("Marcas");

					ddlCategoria.DataSource = categorias;
					ddlCategoria.DataValueField = "id";
					ddlCategoria.DataTextField = "Descripcion"; //Lo que muestra
					ddlCategoria.DataBind();

					ddlMarca.DataSource = marcas;
					ddlMarca.DataValueField = "id";
					ddlMarca.DataTextField = "Descripcion"; //Lo que muestra
					ddlMarca.DataBind();
				}        
			}
			catch (Exception ex)
			{

				Session.Add("Error", ex);
			}
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
			{
				Articulo nuevo = new Articulo();
				Negocio Articulo = new Negocio();

				nuevo.Nombre = txtNombre.Text;
				nuevo.Codigo = txtCodigo.Text;
				nuevo.Descripcion = txtDescripcion.Text;
				nuevo.Precio = int.Parse(txtPrecio.Text);
				nuevo.ImagenUrl= txtImagenUrl.Text;

				nuevo.Marca = new Elemento();
				nuevo.Marca.Id= int.Parse(ddlMarca.SelectedValue);
				nuevo.Categoria = new Elemento();
                nuevo.Categoria.Id = int.Parse(ddlCategoria.SelectedValue);

				Articulo.agregar(nuevo);
                Response.Redirect("Lista.aspx", false);
            }
            catch (Exception ex)
			{

                lblError.Text = "Error: " + ex.Message;
            }
        }
		protected void txtImagenUrl_TextChanged(object sender, EventArgs e)
		{
            imgArticulo.ImageUrl = txtImagenUrl.Text;
		}
	}
}