<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfConsumir SOAP.aspx.cs" Inherits="ServicioSOAP.wfConsumir_SOAP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>

</head>

<body>
    <form id="form1" runat="server">
        <div class="form-grop row mt-5" style="text-align:center">

            <div class="col-sm-2">
                <asp:Button ID="btnObjetoSOAP" CssClass="btn btn-primary" Text="Llamar Objeto SOAP" OnClick="btnObjetoSOAP_Click" runat="server" />
            </div>

            <div class="col-sm-2">
                <asp:Button ID="btnMatrizSOAP" CssClass="btn btn-primary" Text="Llamar Matriz SOAP" OnClick="btnMatrizSOAP_Click" runat="server" />
            </div>

            <div class="col-sm-2">
                <asp:Button ID="btnLogueo" CssClass="btn btn-primary" Text="Llamar Logueo SOAP" Onclick="btnLogueo_Click" runat="server" />
            </div>

            <div class="col-sm-2">
                <asp:Button ID="btnLista" CssClass="btn btn-primary" Text="Llamar Lista SOAP" OnClick="btnLista_Click" runat="server" />
            </div>
        </div>

        <div class="form-grop row mt-5" style="text-align:center">
            <asp:GridView id="dgvUsuarios" runat="server"></asp:GridView>
        </div>

    </form>

    <!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
</body>
</html>
