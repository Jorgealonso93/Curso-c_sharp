<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="CRUDEstatusWF.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblElim" runat="server" Text="Eliminar"></asp:Label>
            <br />
            <asp:Label ID="lblIdElim" runat="server" Text="ID"></asp:Label>
&nbsp;<asp:TextBox ID="txtIdElim" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblNomElim" runat="server" Text="Nombre"></asp:Label>
&nbsp;<asp:TextBox ID="txtNomelim" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblClaElim" runat="server" Text="Clave"></asp:Label>
&nbsp;<asp:TextBox ID="txtClaElim" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClick="btnDelete_Click" />
            <br />
            <a href="Index.aspx">Ir al principio de la página</a>
            <br />
        </div>
    </form>
</body>
</html>
