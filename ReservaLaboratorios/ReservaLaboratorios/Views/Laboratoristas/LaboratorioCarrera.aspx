<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaLaboratorio.Master" AutoEventWireup="true" CodeBehind="LaboratorioCarrera.aspx.cs" Inherits="ReservaLaboratorios.Views.Laboratoristas.LaboratorioCarrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="title-content">
        <h5 class="title">Laboratorio exclusivo</h5>
    </div>
    <h4 id="nombreLboratorio" runat="server" class="text-center"></h4>
    <hr />
    <div class="container">
        <label><b>SELECCIONE UNA CARRERA</b></label>
        <br />
        <br />
        <asp:DropDownList ID="ddlCarreras" runat="server" CssClass="form-control custom-input"></asp:DropDownList>
        <br />
        <div class="text-center">
            <asp:Button ID="btnGuardar" runat="server" Text="Agregar" CssClass="btn btn-primary" OnClick="btnGuardar_Click"/>
        </div>  
    </div>
    <br />
    <div class="alert alert-info alert-dismissible text-center" id="lblMsgLstRegistros" runat="server" visible="false">
        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
            <span aria-hidden="true">&times;</span>
        </button>
        <span class="mensaje">No existen registros</span>
    </div>
    <asp:Label ID="lblFacultadId" runat="server" Text="" Visible="false"></asp:Label>
    <asp:Label ID="lblSedeId" runat="server" Text="" Visible="false"></asp:Label>
    <asp:GridView ID="gvCarreras" runat="server" AutoGenerateColumns="False" OnRowCommand="gvCarreras_RowCommand" CssClass="table table-cielo table-hover tbl-buscador dataTable no-footer">
        <Columns>
            <asp:BoundField DataField="strNombre_Car" HeaderText="Nombre" />
            <asp:TemplateField ShowHeader="False" HeaderText="Accion" ItemStyle-CssClass="text-center" HeaderStyle-CssClass="text-center">
                <ItemTemplate>
                    <!--Boton para eliminar el laboratorio-->
                    <asp:ImageButton ID="imgbtnDelete" runat="server" CausesValidation="False" CommandName="Eliminar" CssClass="btn btn-danger" ImageUrl="~/images/static/delete.svg" CommandArgument ='<%# Eval("strCod_labEx") %>' OnClientClick="return confirm('¿Seguro que desea eliminar?');" data-toggle="tooltip" data-placement="bottom" title="Eliminar"/>&nbsp;&nbsp;
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <script type="text/javascript">
        function showAlertAndReload(title, icon) {
            const Toast = Swal.mixin({
                toast: true,
                position: "top-end",
                showConfirmButton: false,
                timer: 3000,
                timerProgressBar: true,
                didOpen: (toast) => {
                    toast.addEventListener('mouseenter', Swal.stopTimer);
                    toast.addEventListener('mouseleave', Swal.resumeTimer);
                }
            });

            Toast.fire({
                icon: icon,
                title: title
            }).then(() => {
                // Recargar la página una vez que el toast desaparezca
                window.location.href = window.location.pathname;
            });
        }
    </script>
</asp:Content>
