<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePromo.Master" AutoEventWireup="true" CodeBehind="IngresarDatos.aspx.cs" Inherits="TPPromoWeb_Equipo4B.IngresarDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>¡Promo Ganá! - Ingresá tus datos</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script>
        function validarCheckbox() {
            var checkbox = document.getElementById('checkbox');
            var errorSpan = document.getElementById('checkboxError');

            if (!checkbox.checked) {
                errorSpan.style.display = 'inline';
                return false;
            }
            errorSpan.style.display = 'none';
            return true;
        }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav class="navbar navbar-dark bg-dark">
        <div class="container-fluid">
            <span class="navbar-brand mb-0 h1">Promo Ganá!</span>
        </div>
    </nav>

            <div class="container mt-5">
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <h2 id="aspnetTitle" class="mb-4">Ingresar Datos:</h2>

                    <div class="mb-3 row">
    <div class="col-md-8">
        <label for="txtDNI" class="form-label">DNI</label>
       








    
</asp:Content>


