<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="CRUDEstatusWF.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblIdDet" runat="server" Text="ID"></asp:Label>
    <asp:TextBox ID="txtIdDet" runat="server"></asp:TextBox>
    <asp:Label ID="lblNomDet" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNomDet" runat="server"></asp:TextBox>
    <asp:Label ID="lblClaDet" runat="server" Text="Clave"></asp:Label>
    <asp:TextBox ID="txtClaveDet" runat="server"></asp:TextBox>
    <a href="Index.aspx">Ir al principio de la página</a>
</asp:Content>
