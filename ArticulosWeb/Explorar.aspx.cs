﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegocioArticulo;
using Dominio;

namespace ArticulosWeb
{
    public partial class Explorar : Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        public bool FiltroAvanzado { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio Articulos = new Negocio();
            ListaArticulos = Articulos.listarConSP();
            
        }
    }
}