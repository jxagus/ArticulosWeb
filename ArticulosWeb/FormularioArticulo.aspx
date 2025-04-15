<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioArticulo.aspx.cs" Inherits="ArticulosWeb.FormularioArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <!-- Columna del formulario -->
        <div class="col-6">
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtCodigo" class="form-label">Código</label>
                <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="ddlMarca" class="form-label">Marca</label>
                <asp:DropDownList ID="ddlMarca" runat="server" CssClass="form-select">
                    <asp:ListItem Text="Seleccione una marca" Value="" />
                    <asp:ListItem Text="Sony" Value="1" />
                    <asp:ListItem Text="Samsung" Value="2" />
                    <asp:ListItem Text="LG" Value="3" />
                </asp:DropDownList>
            </div>

            <div class="mb-3">
                <label for="ddlCategoria" class="form-label">Categoría</label>
                <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-select">
                    <asp:ListItem Text="Seleccione una categoría" Value="" />
                    <asp:ListItem Text="Audio" Value="1" />
                    <asp:ListItem Text="Video" Value="2" />
                    <asp:ListItem Text="Accesorios" Value="3" />
                </asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" />
                <a href="Lista.aspx" class="btn btn-secondary ms-2">Cancelar</a>
            </div>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" />

        </div>

        <!--Columna para la imagen !-->
        <div class="col-6">
            <div class="mb-3">
                <div class="mb-3">
                    <label for="txtDescripcion" class="form-label">Descripción</label>
                    <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" CssClass="form-control" />
                </div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="mb-3">
                            <label for="txtImagenUrl" runat="server" text="Label">Link de imagen</label>
                            <asp:TextBox ID="txtImagenUrl" CssClass="form-control" runat="server"
                                AutoPostBack="true" OnTextChanged="txtImagenUrl_TextChanged" />
                        </div>
                        <asp:Image ID="imgArticulo" runat="server" ImageUrl="Img/Foto.png" Width="60%" />


                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>

</asp:Content>
