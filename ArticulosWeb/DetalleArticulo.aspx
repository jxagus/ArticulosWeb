<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="ArticulosWeb.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FullWidthContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Detalle del articulo</h2>
    <h2><%: ArticuloDetalle.Nombre %></h2>
    <p><%: ArticuloDetalle.Descripcion %></p>
    <p>Precio: $<%: ArticuloDetalle.Precio %></p>
    <img src="<%: string.IsNullOrEmpty(ArticuloDetalle.ImagenUrl) ? "Img/NoDisponible.jpg" : ArticuloDetalle.ImagenUrl %>" width="300" />

</asp:Content>
