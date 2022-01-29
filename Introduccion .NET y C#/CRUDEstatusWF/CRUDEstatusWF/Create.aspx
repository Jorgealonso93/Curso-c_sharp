<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="CRUDEstatusWF.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <asp:Label ID="lbl" runat="server" Text="Clave"></asp:Label>
    <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
    <asp:Button ID="btnAgregar" runat="server" Text="Guardar" OnClick="btnAgregar_Click" />
    <a href="Index.aspx">Ir al principio de la página</a>
</asp:Content>
