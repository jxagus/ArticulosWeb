<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="ArticulosWeb.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FullWidthContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <!-- falopa de codepen.io-->


    <h1>hubo un problema</h1>
    <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="btnVolver" runat="server" Text="Volver al inicio" class="btn btn-dark" OnClick="btnVolver_Click" />

</asp:Content>
