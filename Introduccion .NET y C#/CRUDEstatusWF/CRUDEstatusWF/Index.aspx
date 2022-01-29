<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CRUDEstatusWF.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:DropDownList ID="ddlEstatus" runat="server" OnSelectedIndexChanged="ddlEstatus_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button ID="btnCreate" runat="server" Text="Agregar" OnClick="btnCreate_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Actualizar" OnClick="btnEdit_Click" />
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
</asp:Content>
