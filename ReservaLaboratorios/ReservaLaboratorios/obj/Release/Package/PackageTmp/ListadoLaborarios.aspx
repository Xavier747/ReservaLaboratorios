
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoLaborarios.aspx.cs" Inherits="ReservaLaboratorios.ListadoLaborarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2 class="mb-4">Listado de los Laboratorios</h2>
    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#form_registrar">
        <i class="bi bi-plus-lg"></i>Nuevo laboratorio
    </button>
    <br />
    <br />
    <!-- GridView para listar laboratorios -->
    <asp:GridView ID="gvLaboratorios" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnRowDeleting="gvLaboratorios_RowDeleting" OnSelectedIndexChanged="gvLaboratorios_SelectedIndexChanged" DataKeyNames="strId_LABORATORIO">
        <Columns>
            <asp:BoundField DataField="strId_LABORATORIO" HeaderText="ID"/>
            <asp:BoundField DataField="strNombre_LABORATORIO" HeaderText="Nombre" />
            <asp:BoundField DataField="intCapacidad_LABORATORIO" HeaderText="Capacidad" />
            <asp:BoundField DataField="strUbicacion_LABORATORIO" HeaderText="Ubicación" />
            <asp:BoundField DataField="strTipo_LABORATORIO" HeaderText="Tipo" />
            <asp:BoundField DataField="bitEstado_LABORATORIO" HeaderText="Estado" />
            <asp:TemplateField ShowHeader="False" HeaderText="Accion">
                <ItemTemplate>
                    <div style="display:flex;">
                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Select" CssClass="btn btn-warning" ImageUrl="~/images/static/edit.svg"/>&nbsp;&nbsp;
                        <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" CssClass="btn btn-danger " ImageUrl="~/images/static/delete.svg"/>
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView> 
    
    <div class="container">
        <!-- Ventana Modal -->
        <div class="modal fade" id="form_registrar" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document" style="margin: 30px auto !important; left: 0% !important;">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                        <h4 class="modal-title" id="myModalLabel">Nuevo Laboratorio</h4>
                    </div>
                    <div class="modal-body">
                        <div class="card-body">
                            <div class="form-group">
                                <i class="bi-eye-slash"></i> <asp:Label ID="lbl_nombre" runat="server" Text="Nombre" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="tbx_nombre" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvtbx_nombre" runat="server" ControlToValidate="tbx_nombre" CssClass="alert alert-danger form-control" ValidationGroup="formulario" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lbl_capacidad" runat="server" Text="Capacidad" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="tbx_capacidad" runat="server" CssClass="form-control" placeholder="Capacidad"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lbl_Ubicacion" runat="server" Text="Ubicación" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="tbx_ubicacion" runat="server" CssClass="form-control" placeholder="Ubicación"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lbl_Tipo" runat="server" Text="Tipo" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="tbx_Tipo" runat="server" CssClass="form-control" placeholder="Tipo"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Label1" runat="server" Text="Campo amplio" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="tbx_Campo" runat="server" CssClass="form-control" placeholder="Campo amplio"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lbl_Estado" runat="server" Text="Estado" CssClass="control-label"></asp:Label>
                                <asp:DropDownList ID="Select_Estado" runat="server" class="form-control"></asp:DropDownList>
                            </div>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <div class="form-group">
                                        <asp:Label ID="lbl_sedes" runat="server" Text="Sedes" CssClass="control-label"></asp:Label>
                                        <asp:DropDownList ID="DropDownListSedes" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="DropDownListSedes_SelectedIndexChanged"></asp:DropDownList>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="lbl_facultades" runat="server" Text="Facultades" CssClass="control-label"></asp:Label>
                                        <asp:DropDownList ID="DropDownListFacultades" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="DropDownListSedes" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>

                            <div class="form-group">
                                <asp:Label ID="Label2" runat="server" Text="Fotografia 1" CssClass="control-label"></asp:Label>
                                <asp:FileUpload ID="img1" runat="server" CausesValidation="true"  CssClass="form-control" accept="image/*"/>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Label3" runat="server" Text="Fotografia 2" CssClass="control-label"></asp:Label>
                                <asp:FileUpload ID="img2" runat="server" CssClass="form-control" accept="image/*"/>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                        <asp:Button ID="btnSubmit" runat="server" Text="Enviar" ValidationGroup="formulario" CssClass="btn btn-primary" OnClick="btnSubmit_Click"/>
                    </div>
                </div>
            </div>
        </div>
    
    </div>
    <div class="container">
        <!-- Ventana Modal -->
        <div class="modal fade" id="form_actualizar" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document" style="margin: 30px auto !important; left: 0% !important;">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                            <h4 class="modal-title" id="myModalLabel1">Actualizar Laboratorio</h4>
                        </div>
                        <div class="modal-body">
                            <div class="card-body">
                                <div class="form-group">
                                    <asp:Label ID="lblCodeId" runat="server" Text="" Visible="False"></asp:Label>
                                    <i class="bi-eye-slash"></i> <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="control-label"></asp:Label>
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" CssClass="alert alert-danger form-control" ValidationGroup="formularioActualizar" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblCapacidad" runat="server" Text="Capacidad" CssClass="control-label"></asp:Label>
                                    <asp:TextBox ID="txtCapacidad" runat="server" CssClass="form-control" placeholder="Capacidad"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblUbicacion" runat="server" Text="Ubicación" CssClass="control-label"></asp:Label>
                                    <asp:TextBox ID="txtUbicacion" runat="server" CssClass="form-control" placeholder="Ubicación"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblTipo" runat="server" Text="Tipo" CssClass="control-label"></asp:Label>
                                    <asp:TextBox ID="txtTipo" runat="server" CssClass="form-control" placeholder="Tipo"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblCampoAmplio" runat="server" Text="Campo amplio" CssClass="control-label"></asp:Label>
                                    <asp:TextBox ID="txtCampoAmplio" runat="server" CssClass="form-control" placeholder="Campo amplio"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblEstado" runat="server" Text="Estado" CssClass="control-label"></asp:Label>
                                    <asp:DropDownList ID="selectEstado1" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                        <div class="form-group">
                                            <asp:Label ID="Label10" runat="server" Text="Sedes" CssClass="control-label"></asp:Label>
                                            <asp:DropDownList ID="selectSede" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="selectSede_SelectedIndexChanged" ></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="Label11" runat="server" Text="Facultades" CssClass="control-label"></asp:Label>
                                            <asp:DropDownList ID="selecFacultad" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="selectSede" EventName="SelectedIndexChanged" />
                                    </Triggers>
                                </asp:UpdatePanel>

                                <div class="form-group">
                                    <asp:Label ID="Label12" runat="server" Text="Fotografia 1" CssClass="control-label"></asp:Label>
                                    <asp:FileUpload ID="ImgUpdate1" runat="server" CausesValidation="true"  CssClass="form-control" accept="image/*"/>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label13" runat="server" Text="Fotografia 2" CssClass="control-label"></asp:Label>
                                    <asp:FileUpload ID="ImgUpdate2" runat="server" CssClass="form-control" accept="image/*"/>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                            <asp:Button ID="btn_Actualizar" runat="server" Text="Actualizar" ValidationGroup="formularioActualizar" CssClass="btn btn-success" OnClick="btn_Actualizar_Click"/>
                        </div>
                    </div>
            </div>
        </div>
    
    </div>

</asp:Content>
