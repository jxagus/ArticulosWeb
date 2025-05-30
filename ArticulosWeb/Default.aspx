<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ArticulosWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="hero-section" style="margin-top: 5px;">
        <div class="hero-overlay">
            <div class="hero-content">
                <h1 class="display-4 fw-bold">Articles Shop</h1>
                <p class="lead">Bienvenidos a la página número 1# de venta de artículos de la Argentina</p>
                <a href="Explorar.aspx" class="btn btn-danger btn-lg mt-3">Ver ahora mismo</a>
            </div>
        </div>
    </div>
    <!-- test explorar -->

    <!-- Ofertas unicas en Iphones -->
    <h2>Nuestros celulares</h2>
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% foreach (Dominio.Articulo item in ListaCelulares)
            { %>
        <div class="col">
            <div class="card">
                <%
                    string imagenUrl = string.IsNullOrEmpty(item.ImagenUrl) ? "Img/NoDisponible.jpg" : item.ImagenUrl;
                    if (!imagenUrl.StartsWith("https"))
                    {
                        imagenUrl = "Img/NoDisponible.jpg";
                    }
                %>
                <img src="<%: imagenUrl %>" class="img-thumbnail"
                    style="height: 200px; width: 100%; object-fit: contain; background-color: #f8f9fa;"
                    alt="Imagen del artículo">

                <div class="card-body">
                    <h5 class="card-title"><%: item.Nombre %></h5>
                    <p class="card-text"><%:"$"+ item.Precio %></p>
                    <a href='DetalleArticulo.aspx?id=<%: item.Id %>' class="btn btn-primary">Ver detalles</a>
                   <!-- <a href="Carrito.aspx" class="btn btn-primary">Comprar</a> -->

                </div>
            </div>
        </div>
        <% } %>
    </div>

    <!-- Nuestros productos destacados -->
    <h2>Otros de nuestros productos</h2>
    <div class="col-6">
        <div class="mb-3">
        </div>
    </div>
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% foreach (Dominio.Articulo item in ListaSinCelulares)
            { %>
        <div class="col">
            <div class="card">
                <%
                    string imagenUrl = string.IsNullOrEmpty(item.ImagenUrl) ? "Img/NoDisponible.jpg" : item.ImagenUrl;
                    if (!imagenUrl.StartsWith("https"))
                    {
                        imagenUrl = "Img/NoDisponible.jpg";
                    }
                %>
                <img src="<%: imagenUrl %>"
                    class="img-thumbnail"
                    style="height: 200px; width: 100%; object-fit: contain; background-color: #f8f9fa;"
                    alt="Imagen del artículo">

                <div class="card-body">
                    <h5 class="card-title"><%: item.Nombre %></h5>
                    <p class="card-text"><%:"$"+ item.Precio %></p>
                    <a href='DetalleArticulo.aspx?id=<%: item.Id %>' class="btn btn-primary">Ver detalles</a>
                   <!-- <a href="Carrito.aspx" class="btn btn-primary">Comprar</a> -->
                </div>
            </div>
        </div>
        <% } %>
    </div>
</asp:Content>
