<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="ArticulosWeb.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FullWidthContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Detalle del articulo</h2>
<div class="container mt-5">
    <div class="row">
        <div class="col-md-5">
            <img src="<%: string.IsNullOrEmpty(ArticuloDetalle.ImagenUrl) ? "Img/NoDisponible.jpg" : ArticuloDetalle.ImagenUrl %>" 
                 class="img-fluid rounded border" 
                 alt="Imagen del artículo" />
        </div>
        <div class="col-md-7">
            <h2 class="fw-bold text-dark"><%: ArticuloDetalle.Nombre %></h2>
            <h4 class="text-success mt-3">$<%: ArticuloDetalle.Precio.ToString("N2") %></h4>
            <hr />
            <h5 class="text-secondary">Descripción del producto</h5>
            <p><%: ArticuloDetalle.Descripcion %></p>
        </div>
    </div>
</div>


</asp:Content>
