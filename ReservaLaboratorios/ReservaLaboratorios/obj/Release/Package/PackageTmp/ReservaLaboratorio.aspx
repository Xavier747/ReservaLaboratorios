<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservaLaboratorio.aspx.cs" Inherits="ReservaLaboratorios.ReservaLaboratorio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="calendar"></div>
    <div class="modal fade" id="form_registrar" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog modal-lg" role="document" style="margin: 30px auto !important; left: 0% !important;">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                    <h4 class="modal-title" id="myModalLabel">Nueva reservacion</h4>
                </div>
                <div class="modal-body">
                    <fieldset style="border: 1px solid #000; padding:20px;">
                        <legend style="font-weight:bold; font-size:17px; width:250px;">DATOS DEL LABORATORIO</legend>
                        <div class="row">
                            <div class="col-md-4">
                                <label class="form-label">NOMBRE:</label>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <label class="form-label">RESPONSABLE ACADEMICO:</label>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <label class="form-label">RESPONSABLE ADMINISTRATIVO:</label>
                                <asp:TextBox ID="TextBox3" runat="server" ViewStateMode="Disabled" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </fieldset>
                    <fieldset style="border: 1px solid #000; padding:20px;">
                        <legend style="font-weight:bold; font-size:17px; width:250px;">DATOS DEL SOLICITANTE</legend>
                        <div class="row">
                            <div class="col-md-6">
                                <label class="form-label">NOMBRE:</label>
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label class="form-label">RESPONSABLE ACADEMICO:</label>
                                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </fieldset>
                    <fieldset style="border: 1px solid #000; padding:20px;">
                        <legend style="font-weight:bold; font-size:17px; width:250px;">FECHA Y HORA</legend>
                        <div class="row">
                            <div class="col-md-3">
                                <label class="form-label">FECHA:</label>
                                <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label class="form-label">HORA DE INICIO:</label>
                                <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label class="form-label">HORA DE FINALIZACION:</label>
                                <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label class="form-label"></label>
                                <asp:Button ID="Button1" runat="server" Text="Verificar" class="btn btn-primary"/>
                            </div>
                        </div>
                    </fieldset>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                    <asp:Button ID="btnSubmit" runat="server" Text="Enviar" ValidationGroup="formulario" CssClass="btn btn-primary"/>
                </div>
            </div>
        </div>
    </div>
<script>
    document.addEventListener('DOMContentLoaded', function() {
        var calendarEl = document.getElementById('calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            initialView: 'dayGridMonth',
            locale: 'es',
            dateClick: function(info) {
                $('#eventDate').val(info.dateStr);
                $('#form_registrar').modal('show');
            },
            dayHeaderContent: function(arg) {
                switch (arg.date.getUTCDay()) {
                    case 0:
                        return 'Dom';
                    case 1:
                        return 'Lun';
                    case 2:
                        return 'Mar';
                    case 3:
                        return 'Mié';
                    case 4:
                        return 'Jue';
                    case 5:
                        return 'Vie';
                    case 6:
                        return 'Sáb';
                }
            }
        });
        calendar.render();
    });

    $('#eventForm').on('submit', function(e) {
        e.preventDefault();
        var title = $('#eventTitle').val();
        var date = $('#eventDate').val();
        var time = $('#eventTime').val();
        var eventData = {
            title: title,
            start: date + 'T' + time
        };
        // Aquí puedes agregar el código para guardar el evento en tu base de datos
        $('#eventModal').modal('hide');
    });
</script>


</asp:Content>
