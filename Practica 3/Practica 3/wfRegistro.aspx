<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="wfRegistro.aspx.cs" Inherits="Practica_3.wfRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-control">
        <div class="col-sm-12" style="text-align:center">
            <h4>REPORTE ESTADO DE SALUD EMPLEADO</h4>
        </div>

    </div>

    <div class="form group row p-2" style="margin-top:1rem">
        <div class="col-sm-3" style="text-align:center">
            <asp:Label Text="Ingrese su cédula" runat="server" />
        </div>
        <div class="col-sm-3">
            <asp:TextBox runat="server" id="txtCecula" placeholder="Cédula" type="number" CssClass="form-control" ValidationGroup="ValidarEmpleado" required/>
        </div>
        <div class="col-sm-3">
            <asp:Label Text="Ingrese su nombre" runat="server" />
        </div>
        <div class="col-sm-3">
            <asp:TextBox runat="server" id="txtNombre" placeholder="Nombre" CssClass="form-control" ValidationGroup="ValidarEmpleado" required/>
        </div>

    </div>

    <div class="form-group row p-2">
        <div class="col-sm-3" style="text-align:center">
            <asp:Label Text="Ingrese el correo" runat="server" />
        </div>
        <div class="col-sm-3">
            <asp:TextBox runat="server" id="txtCorreo" placeholder="Correo" type="email" CssClass="form-control" ValidationGroup="ValidarEmpleado" required />
        </div>
        <div class="col-sm-3">
            <asp:Label Text="Fecha de nacimiento" runat="server" />
        </div>
        <div class="col-sm-3">
            <asp:TextBox runat="server" id="txtRegitro" CssClass="form-control" ValidationGroup="ValidarEmpleado" required/>
        </div>

    </div>

    <div class="form-group row p-2" style="text-align:center">
        <div class="col-sm-9">
            <asp:CheckBox Text="  Acepto tratamiento de datos" ID="chkTratamiento" CssClass="form-check-input border border-primary" runat="server" required />
        </div>
        <div class="col-sm-2" style="text-align:left">
            <asp:Button Text="Guardar" runat="server" id="txtGuardar" CssClass="btn btn-primary" ValidationGroup="ValidarEmpleado" CausesValidation="true" />
        </div>
    </div>

    <div class="form-group row">
        <div class="col-sm-3">
            <asp:GridView ID="gvUsuarios" runat="server" HorizontalAlign="Center" AutoGenerateColumns="false" BackColor="#adb5bd" BorderColor="#ffffff">
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="col-sm-3"  style="text-align:left">
            <asp:DropDownList ID="ddlNombres" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlNombres_Change" AutoPostBack="True"></asp:DropDownList>
        </div>
    </div>



</asp:Content>
