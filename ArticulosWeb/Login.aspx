<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ArticulosWeb.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mb-6">
        <div class="mb-3">
            <label class="form-label">User</label>
            <asp:TextBox runat="server" ID="txtUser" placeholder="user name" CssClass="form-control" />
        </div>
        <div class="mb-3">
            <label class="form-label">Password</label>
            <asp:TextBox runat="server" placeholder="*****" ID="txtPassword" CssClass="form-control" TextMode="Password" />
        </div>
        <div class="mb-3 form-check">
        </div>
        <asp:Button Text="Ingresar" runat="server" ID="btnIngresar" OnClick="btnIngresar_Click" CssClass="btn btn-primary" />
        <a href="Default.aspx">Cancelar</a>
    </div>

</asp:Content>
