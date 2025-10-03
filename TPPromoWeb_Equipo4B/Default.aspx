<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePromo.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPPromoWeb_Equipo4B.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row position-absolute top-50 start-50 translate-middle">
        <div class="mb-3">
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Ingresa el código de tu voucher</label>
                <asp:TextBox runat="server" class="form-control" ID="txtIngVoucher" />
            </div>
            <div class="d-grid gap-2 col-6 mx-auto">
                <asp:Button runat ="server" class="btn btn-primary" type="button" Text="Comprobar" OnClick="btnComprobar"/>                
            </div>
        </div>
    </div>

</asp:Content>
