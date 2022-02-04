<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Alumnos.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="form-horizontal">
<h2>Listado Alumnos</h2>
<hr />
</div>
<div>
    <asp:Button ID="btnCreate" CssClass="btn btn-primary" runat="server" Text="Agregar" OnClick="btnCreate_Click" />
</div>
<asp:GridView ID="dgvAlumno" runat="server" AutoGenerateColumns="False" BorderStyle="None" CssClass="table" GridLines="Horizontal" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="5" AllowPaging="True" OnPageIndexChanging="dgvAlumno_PageIndexChanging" OnRowCommand="dgvAlumno_RowCommand">
    <Columns>
        <asp:BoundField DataField="ID" HeaderText="Id" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="primerApellido" HeaderText="Primer Apellido" />
        <asp:BoundField DataField="segunndoApellido" HeaderText="Segundo Apellido" />
        <asp:BoundField DataField="Correo" HeaderText="Correo" />
        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
        <asp:BoundField DataField="Estado" HeaderText="Estado" />
        <asp:BoundField DataField="Estatus" HeaderText="Estatus" />
        <asp:ButtonField CommandName="Consultar" Text="Detalles" >
        <ControlStyle BorderStyle="Ridge" CssClass="btn btn-warning" />
        </asp:ButtonField>
        <asp:ButtonField CommandName="Update" Text="Editar" >
        <ControlStyle BorderStyle="Groove" CssClass="btn btn-success" />
        </asp:ButtonField>
        <asp:ButtonField CommandName="Delete" Text="Eliminar" >
        <ControlStyle BorderStyle="Double" CssClass="btn btn-danger" />
        </asp:ButtonField>
    </Columns>
    </asp:GridView>
</asp:Content>
