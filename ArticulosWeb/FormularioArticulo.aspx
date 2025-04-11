<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioArticulo.aspx.cs" Inherits="ArticulosWeb.FormularioArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-select" />
            </div>
            <div class="mb-3">
                <label for="txtCodigo" class="form-label">Codigo</label>
                <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-select" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDescripcion" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtMarca" class="form-label">Marca</label>
                <asp:TextBox runat="server" ID="txtMarca" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtCategoria" class="form-label">Precio</label>
                <asp:ListBox ID="txtCategoria" runat="server"></asp:ListBox>
            </div>
            <div class="mb-3">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" />
                <a href="Lista.aspx">Cancelar</a>
            </div>
        </div>
        <div class="col-6">
            <div class="mb-3">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="txtImagenUrl" runat="server" Text="Label">UrlImagen</label>
                        <asp:TextBox ID="txtImagenUrl" CssClass="form-control" runat="server"
                            autoPostBack="true" OnTextChanged="txtImagenUrl_TextChanged"/>
                    </div>
                    <asp:Image ID="imgArticulo" Width="60%" runat="server" />
                </ContentTemplate>
            </asp:UpdatePanel>      
            </div>
        </div>
    </div>
</asp:Content>
