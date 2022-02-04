<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Presentacion.Alumnos.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
    <h2>Actualizar Alumno</h2>
    <hr />
    <div class="form-group">
        <label for="lblId" class="control-label col-md-2">ID</label>
        <div>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control text-box single-line" Enabled="False"></asp:TextBox>
        </div>
        <br />
        <label for="lblNombre" class="control-label col-md-2">Nombre</label>
        <div>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" CssClass="text-danger" Display="Dynamic" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        </div>
        <br />
        <label for="lblPApellido" class="control-label col-md-2">Primer Apellido</label>
        <div>
            <asp:TextBox ID="txtPApellido" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPApellido" CssClass="text-danger" Display="Dynamic" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        </div>
        <br />
        <label for="lblSApellido" class="control-label col-md-2">Segundo Apellido</label>
        <div>
            <asp:TextBox ID="txtSApelllido" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <br />
        <label for="lblFNacimiento" class="control-label col-md-2">FechaNaciMiento</label>
        <div>
            <asp:TextBox ID="txtFNacimiento" runat="server" CssClass="form-control text-box single-line" TextMode="Date"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtFNacimiento" CssClass="text-danger" Display="Dynamic" ErrorMessage="Fuera del Rango Permitido" MaximumValue="31/12/2000" MinimumValue="01/01/1990" Type="Date"></asp:RangeValidator>
        </div>
        <br />
        <label for="lblCurp" class="control-label col-md-2">CURP</label>
        <div>
            <asp:TextBox ID="txtCurp" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCurp" CssClass="text-danger" Display="Dynamic" ErrorMessage="El formato no Cumple" ValidationExpression="^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{1}[0-9]{1}$"></asp:RegularExpressionValidator>
        </div>
        <br />
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="la fecha de naciemiento no coincide con el de la CURP" ClientValidationFunction="validarFechas" CssClass="text-danger"></asp:CustomValidator>
        <br />
        <label for="lblCorreo" class="control-label col-md-2">Correo</label>
        <div>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" placeholder="nombre@ejemplo.com" ControlToValidate="txtCorreo" CssClass="text-danger" Display="Dynamic" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        </div>
        <br />
        <label for="lblTelefono" class="control-label col-md-2">Teléfono</label>
        <div>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control text-box single-line" TextMode="Phone"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtTelefono" CssClass="text-danger" Display="Dynamic" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
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
            <asp:Button ID="btnUpdate" runat="server" Text="Guardar" OnClick="Button1_Click" CssClass="btn btn-default"/>
        </div>
    </div>
    <div class="form-group">
        <div>
            <a href="/Alumnos/Index.aspx">Regresar a la lista</a>
        </div>
    </div>  
    <script type="text/javascript">
        function validarFechas(sender, arguments) {
            var tbFN = document.getElementById('<%=txtFNacimiento.ClientID %>').value;
            //1997-07-15
            var tbCurp = document.getElementById('<%=txtCurp.ClientID %>').value;
            var fCurp = tbCurp.substr(4, 6);
            var day = parseInt(fCurp.substr(4, 2)) ;
            var month = parseInt(fCurp.substr(2, 2)) - 1;
            var year = parseInt(fCurp.substr(0, 2));
            //var fech = year + "-" + month + "-" + day;
            tbFN = tbFN.split('-');
            var year1 = parseInt(tbFN[0]);
            var month1 = parseInt(tbFN[1]) - 1;
            var day1 = parseInt(tbFN[2]);
            //var fech2 = year1 + "-" + month1 + "-" + day1;
            var FechNaci = new Date(year1, month1, day1).toLocaleDateString('en-USA');
            fCurp = new Date(year, month, day).toLocaleDateString('en-USA');
            var verdadera=3;
            var falsa=5;
            //FechNaci = moment(FechNaci).format('YYYY-MM-DD');
            //fCurp = moment(fCurp).format('YYYY-MM-DD');
            //970715
            //tbFN.toISOString();
            //fCurp.toISOString();

            if (FechNaci == fCurp) {
                //arguments.IsValid = true;
                verdadero = 6;
            } else {
                //arguments.IsValid = false;
                falsa = 4;
            }
        }
    </script>
</div>
</asp:Content>
