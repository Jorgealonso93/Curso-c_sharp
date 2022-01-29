<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="CRUDEstatusWF.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblIdAc" runat="server" Text="ID"></asp:Label>
    <asp:TextBox ID="txtIdAct" runat="server"></asp:TextBox>
    <asp:Label ID="lblNomAct" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNomAct" runat="server"></asp:TextBox>
    <asp:Label ID="lblClaAct" runat="server" Text="Clave"></asp:Label>
    <asp:TextBox ID="txtClaAct" runat="server"></asp:TextBox>
    <asp:Button ID="btnAct" runat="server" Text="Actualizar" OnClick="btnAct_Click" />
    <a href="Index.aspx">Ir al principio de la página</a>
</asp:Content>
