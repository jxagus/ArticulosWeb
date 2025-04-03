﻿<%@ Page Title="Explorar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Explorar.aspx.cs" Inherits="ArticulosWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de artículos</h1>

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% foreach (Dominio.Articulo item in ListaArticulos)
            { %>
        <div class="col">
            <div class="card">
                <img src="<%: item.ImagenUrl %>" class="img-thumbnail"
                    style="height: 200px; width: 100%; object-fit: contain; background-color: #f8f9fa;"
                    alt="Imagen del artículo">

                <div class="card-body">
                    <h5 class="card-title"><%: item.Nombre %></h5>
                    <p class="card-text"><%: item.Descripcion %></p>
                    <a href="#" class="btn btn-primary">Ver más</a>
                </div>
            </div>
        </div>
        <% } %>
    </div>


</asp:Content>
