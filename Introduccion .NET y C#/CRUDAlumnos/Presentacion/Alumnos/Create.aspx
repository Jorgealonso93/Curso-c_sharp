<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentacion.Alumnos.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
    <h2>Agregar Alumno</h2>
    <hr />
    <div class="form-group">
        <label for="lblNombre" class="control-label col-md-2">Nombre</label>
        <div>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" Display="Dynamic" ErrorMessage="Campo requerido" CssClass="text-danger" EnableTheming="True"></asp:RequiredFieldValidator>
        </div>
        <br />
        <label for="lblPApellido" class="control-label col-md-2">Primer Apellido</label>
        <div>
            <asp:TextBox ID="txtPApellido" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtPApellido" Display="Dynamic" EnableViewState="False" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
        <br />
        <label for="lblSApellido" class="control-label col-md-2">Segundo Apellido</label>
        <div>
            <asp:TextBox ID="txtSApelllido" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtSApelllido" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
        <br />
        <label for="lblFNacimiento" class="control-label col-md-2">FechaNaciMiento</label>
        <div>
            <asp:TextBox ID="txtFNacimiento" runat="server" CssClass="form-control text-box single-line" TextMode="Date"></asp:TextBox>
        </div>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtFNacimiento" ErrorMessage="No cumple con el Rango" MaximumValue="31/12/2000" MinimumValue="01/01/1990" Type="Date" CssClass="text-danger"></asp:RangeValidator>
        <br/>
        <label for="lblCurp" class="control-label col-md-2">CURP</label>
        <div>
            <asp:TextBox ID="txtCurp" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCurp" Display="Dynamic" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{1}[0-9]{1}$" CssClass="text-danger">El formato no cumple</asp:RegularExpressionValidator>
        </div>
        <br />
        <label for="lblCorreo" class="control-label col-md-2">Correo</label>
        <div>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control text-box single-line" placeholder="nombre@ejemplo.com"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCorreo" CssClass="text-danger" Display="Dynamic" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        </div>
        <br />
        <label for="lblTelefono" class="control-label col-md-2">Teléfono</label>
        <div>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control text-box single-line" TextMode="Phone"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtTelefono" CssClass="text-danger" Display="Dynamic" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        </div>
        <br />
        <label for="lblEstado" class="control-label col-md-2">Estado</label>
        <div>
            <asp:DropDownList ID="ddlEstado" runat="server" Height="34px" Width="100%"></asp:DropDownList>
        </div>
        <br />
        <label for="lblEstatus" class="control-label col-md-2">Estatus</label>
        <div>
            <asp:DropDownList ID="ddlEstatus" runat="server" Height="34px" Width="100%"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <div>
            <asp:Button ID="btnCreate" runat="server" Text="Guardar" OnClick="Button1_Click" CssClass="btn btn-default"/>
        </div>
    </div>
    <div class="form-group">
        <div>
            <a href="/Alumnos/Index.aspx">Regresar a la lista</a>
        </div>
    </div>        
</div>
</asp:Content>
