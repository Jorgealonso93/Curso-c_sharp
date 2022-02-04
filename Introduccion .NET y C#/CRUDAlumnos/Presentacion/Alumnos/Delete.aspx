<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Presentacion.Alumnos.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
	<h2>Eliminar Alumno</h2> 
	<h3>¿ Está seguro que desea eliminar al Alumno?</h3>  
	<hr />
	<dl class="dl-horizontal">
		<dt>
			Id
		</dt>
		<dd>
			<asp:Label ID="lblId" runat="server" Text=""></asp:Label>
		</dd>
		<dt>
			Nombre
		</dt>
		<dd>
			<asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
		</dd>
		<dt>
			Primer Apellido
		</dt>
		<dd>
			<asp:Label ID="lblPApellido" runat="server" Text=""></asp:Label>
		</dd>
		<dt>
			Segundo Apellido
		</dt>
		<dd>
			<asp:Label ID="lblSApellido" runat="server" Text=""></asp:Label>
		</dd>
		<dt>
			Fecha de Nacimiento
		</dt>
		<dd>
			<asp:Label ID="lblFNacimiento" runat="server" Text=""></asp:Label>
		</dd>
		<dt>
			CURP
		</dt>
		<dd>
			<asp:Label ID="lblCurp" runat="server" Text=""></asp:Label>
		</dd>
		<dt>
			Correo
		</dt>
		<dd>
			<asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label>
		</dd>
		<dt>
			Telefono
		</dt>
		<dd>
			<asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label>
		</dd>
		<dt>
			Estado
		</dt>
		<dd>
			<asp:Label ID="lblEstado" runat="server" Text=""></asp:Label>
		</dd>
		<dt>
			Estatus
		</dt>
		<dd>
			<asp:Label ID="lblEstatus" runat="server" Text=""></asp:Label>
		</dd>
	</dl>
	<div class="form-group">
		<div class="col-md-2">
			<a href="/Alumnos/Index.aspx">Regresar a la lista</a>
		</div>
	</div>
	<div class="form-group">
		<div class="col-md-offset-2 col-md-2">
			<asp:Button ID="btnEliminmar" runat="server" Text="Eliminar" OnClick="Button1_Click" CssClass="btn btn-default"/>
		</div>
	</div>	
</div>
</asp:Content>
