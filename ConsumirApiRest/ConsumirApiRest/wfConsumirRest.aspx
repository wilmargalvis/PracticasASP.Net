<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfConsumirRest.aspx.cs" Inherits="ConsumirApiRest.wfConsumirRest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group row">
            <div class="col-sm-3">
                <asp:GridView ID="dgvEmpleados" runat="server" AutoGenerateColumns="false" DataKeyNames="id" HorizontalAlign="Center" BackColor="#adb5bd" BorderColor="#ffffff" OnRowCommand="dgvEmpleados_RowCommand" CssClass="btn btn-primary">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                        <asp:ButtonField Text="Editar" CommandName="Editar"/>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div style="text-align:center">
            <asp:Label ID="lblMensaje" Text="Indice del Registro: " runat="server"/>
        </div>
    </form>
</body>
</html>
