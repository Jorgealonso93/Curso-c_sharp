<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Alumnos.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h2>Datos del Alumno</h2>
        <hr />
        <dl class="dl-horizontal">
            <dt>Id
            </dt>
            <dd>
                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
            </dd>
            <dt>Nombre
            </dt>
            <dd>
                <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
            </dd>
            <dt>Primer Apellido
            </dt>
            <dd>
                <asp:Label ID="lblPApellido" runat="server" Text=""></asp:Label>
            </dd>
            <dt>Segundo Apellido
            </dt>
            <dd>
                <asp:Label ID="lblSApellido" runat="server" Text=""></asp:Label>
            </dd>
            <dt>Fecha de Nacimiento
            </dt>
            <dd>
                <asp:Label ID="lblFNacimiento" runat="server" Text=""></asp:Label>
            </dd>
            <dt>CURP
            </dt>
            <dd>
                <asp:Label ID="lblCurp" runat="server" Text=""></asp:Label>
            </dd>
            <dt>Correo
            </dt>
            <dd>
                <asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label>
            </dd>
            <dt>Telefono
            </dt>
            <dd>
                <asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label>
            </dd>
            <dt>Estado
            </dt>
            <dd>
                <asp:Label ID="lblEstado" runat="server" Text=""></asp:Label>
            </dd>
            <dt>Estatus
            </dt>
            <dd>
                <asp:Label ID="lblEstatus" runat="server" Text=""></asp:Label>
            </dd>
        </dl>
        <div class="form-group">
            <button type="button" runat="server" class="btn btn-info" OnClick="LLamaAJAXPost();" data-toggle="modal" data-target="#myModalISR">ISR</button>
            <button type="button" runat="server" class="btn btn-info" OnClick="LLamaAJAXPostImss();" data-toggle="modal" data-target="#myModalIMMS">IMMS</button>
            <!-- Button trigger modal -->
           <%-- <asp:Button ID="btnImms" runat="server" CssClass="btn btn-info btn-log" data-toggle="modal" data-target="#immsModal" Text="IMMS"  OnClick="btnImms_Click" />
            <asp:Button ID="btnIsr" runat="server" CssClass="btn btn-info btn-log" data-toggle ="modal" data-target="#myModal" Text="ISR" OnClick="btnIsr_Click" />--%>

            <!-- Ventana Modal -->
            <div class="modal" id="myModalISR">
                <div class="modal-dialog">
                    <div class="modal-content">

                        <!-- Encabezado Modal -->
                        <div class="modal-header">
                            <h4 class="modal-title">Calculo ISR</h4>
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                        </div>

                        <!-- Curepo de la Modal -->
                        <div class="modal-body">
                            <dl>
                                <dt>Limite Inferior
                                </dt>
                                <dd>
                                    <asp:Label ID="lblLimInf" runat="server" Text="Label"></asp:Label>
                                </dd>
                                <dt>Limite Superior
                                </dt>
                                <dd>
                                    <asp:Label ID="lblLimSup" runat="server" Text="Label"></asp:Label>
                                </dd>
                                <dt>Cuota
                                </dt>
                                <dd>
                                    <asp:Label ID="lblCuota" runat="server" Text="Label"></asp:Label>
                                </dd>
                                <dt>Excedente
                                </dt>
                                <dd>
                                    <asp:Label ID="lblExced" runat="server" Text="Label"></asp:Label>
                                </dd>
                                 <dt>Subsidio
                                </dt>
                                <dd>
                                    <asp:Label ID="lblSubsidio" runat="server" Text="Label"></asp:Label>
                                </dd>
                                <dt>Impuesto
                                </dt>
                                <dd>
                                    <asp:Label ID="lblImp" runat="server" Text="Label"></asp:Label>
                                </dd>
                            </dl>
                        </div>

                        <!-- Modal footer -->
                        <div class="modal-footer">
                            <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                        </div>

                    </div>
                </div>
            </div>

            <div class="modal" id="myModalIMMS">
                <div class="modal-dialog">
                    <div class="modal-content">

                        <!-- Encabezado Modal -->
                        <div class="modal-header">
                            <h4 class="modal-title">Calculo IMMS</h4>
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                        </div>

                        <!-- Curepo de la Modal -->
                        <div class="modal-body">
                            <dl>
                                <dt>Enfermedad y Maternidad
                                </dt>
                                <dd>
                                    <asp:Label ID="lblMaternidad" runat="server" Text="Label"></asp:Label>
                                </dd>
                                <dt>Invalidez Vida
                                </dt>
                                <dd>
                                    <asp:Label ID="lblInvalidez" runat="server" Text="Label"></asp:Label>
                                </dd>
                                <dt>Retiro
                                </dt>
                                <dd>
                                    <asp:Label ID="lblRetiro" runat="server" Text="Label"></asp:Label>
                                </dd>
                                <dt>Cesantia
                                </dt>
                                <dd>
                                    <asp:Label ID="lblCesantia" runat="server" Text="Label"></asp:Label>
                                </dd>
                                 <dt>Infonavit
                                </dt>
                                <dd>
                                    <asp:Label ID="lblInfonavit" runat="server" Text="Label"></asp:Label>
                                </dd>
                            </dl>
                        </div>

                        <!-- Modal footer -->
                        <div class="modal-footer">
                            <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                        </div>

                    </div>
                </div>
            </div>
            <%--<div id="myModal" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                            <h4 class="modal-title" id="myModalLabel">Calculo ISR</h4>
                        </div>
                        <div class="modal-body">
                            <contenttemplate>
                                Impuesto a pagar:
			                    <asp:Label ID="lblImpuesto" runat="server" Text=""></asp:Label>
                            </contenttemplate>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Aceptar</button>
                        </div>

                    </div>
                    <!-- /.modal-content -->
                </div>
                <!-- /.modal-dialog -->
            </div>

            <div id="immsModal" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                            <h4 class="modal-title" id="immsModalLabel">Calculo IMMS</h4>
                        </div>
                        <div class="modal-body">
                            <contenttemplate>
                                Calculos Totales:
                                <br />
                                Enfermedad Y Maternidad:
                                <asp:Label ID="lblMaternidad" runat="server" Text=""></asp:Label>
                                <br />
                                Invalidez Vida:
                                <asp:Label ID="lblInvalidez" runat="server" Text=""></asp:Label>
                                <br />
                                Retiro:
                                <asp:Label ID="lblRetiro" runat="server" Text=""></asp:Label>
                                <br />
                                Cesantia:
                                <asp:Label ID="lblCesantia" runat="server" Text=""></asp:Label>
                                <br />
                                Infonavit:
                                <asp:Label ID="lblInfonavit" runat="server" Text=""></asp:Label>
                                <br />
                            </contenttemplate>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Aceptar</button>
                        </div>

                    </div>
                    <!-- /.modal-content -->
                </div>
                <!-- /.modal-dialog -->
            </div>--%>
        </div>
        <div class="form-group">
            <div class="col-md-2">
                <a href="/Alumnos/Index.aspx">Regresar a la lista</a>
            </div>
        </div>
        <script type="text/javascript">
            function LLamaAJAXPostImss() {
                var urlws = 'https://localhost:44307/WSAlumno.asmx/CalcularIMMS';
                const valores = window.location.search;
                const urlParams = new URLSearchParams(valores);
                var id = urlParams.get("id");
                var alumno = { id: parseInt(id) };
                var parametros = JSON.stringify(alumno);

                $.ajax({
                    type: 'POST',
                    url: urlws,
                    data: parametros,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: RecibeObjetoIMMS,
                    error: errorGenerico
                });
            }

            function RecibeObjetoIMMS(data) {
                try {
                    imss = data.d;
                    if (imss != null) {
                        $('#<%=lblMaternidad.ClientID%>').html(imss.enfermedadMaternidad);
                        $('#<%=lblInvalidez.ClientID%>').html(imss.invalidezVida);
                        $('#<%=lblRetiro.ClientID%>').html(imss.retiro);
                        $('#<%=lblCesantia.ClientID%>').html(imss.cesantia);
                        $('#<%=lblInfonavit.ClientID%>').html(imss.infonavit);
                        $('#myModalIMMS').modal('show');
                    }
                    else {
                        alert('La respuesta recibida del Web Service es incorrecta ' + data.d);
                    }
                }
                catch (ex) {
                    alumno = [];
                    alert('Error al recibir los datos');
                }
            }

            function LLamaAJAXPost() {
                var urlws = 'https://localhost:44307/WSAlumno.asmx/CalcularISR';
                const valores = window.location.search;
                const urlParams = new URLSearchParams(valores);
                var id = urlParams.get("id");
                var alumno = { id: parseInt(id) };
                var parametros = JSON.stringify(alumno);

                $.ajax({
                    type: 'POST',
                    url: urlws,
                    data: parametros,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: RecibeObjeto,
                    error: errorGenerico
                });
            }
            function RecibeObjeto(data) {
                try {
                    isr = data.d;
                    if (imss != null) {
                        $('#<%=lblLimInf.ClientID%>').html(isr.limInf);
                        $('#<%=lblLimSup.ClientID%>').html(isr.LimSup);
                        $('#<%=lblCuota.ClientID%>').html(isr.cuotaFija);
                        $('#<%=lblExced.ClientID%>').html(isr.excedente);
                        $('#<%=lblSubsidio.ClientID%>').html(isr.subsidio);
                        $('#<%=lblImp.ClientID%>').html(isr.impuesto);
                        $('#myModalISR').modal('show');
                    }
                    else {
                        alert('La respuesta recibida del Web Service es incorrecta ' + data.d);
                    }
                }
                catch (ex) {
                    alumno = [];
                    alert('Error al recibir los datos');
                }
            }
            function errorGenerico(jqXHR, exception) {
                var msg = '';
                if (jqXHR.status === 0) {
                    msg = 'No está conectado, favor de verificar su conexión.';
                }
                else if (jqXHR.status === 404) {
                    msg = 'Página no encontrada [404]';
                }
                else if (jqXHR.status === 500) {
                    msg = 'Error no hay conexión al servidor [500]';
                }
                else if (jqXHR.status === 'parseerror') {
                    msg = 'El parseo del JSON es erróneo.';
                }
                else if (jqXHR.status === 'timeout') {
                    $('body').addClass('loaded');
                }
                else if (jqXHR.status === 'abort') {
                    msg = 'La petición Ajax fue abortada.';
                }
                else {
                    msg = 'Error no conocido. ';
                    console.log(exception);
                }
                alert(msg);
            }
        </script>

    </div>
</asp:Content>
