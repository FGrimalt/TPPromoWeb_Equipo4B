<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePromo.Master" AutoEventWireup="true" CodeBehind="IngresarDatos.aspx.cs" Inherits="TPPromoWeb_Equipo4B.IngresarDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
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
    <div></div>
            <div class="container mt-5"> 
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <h2 id="aspnetTitle" class="mb-4">Ingresar Datos:</h2>

                    <div class="mb-3 row">
    <div class="col-md-8">
        <label for="txtDNI" class="form-label">DNI</label>

        <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" placeholder="ingrese DNI" type="text" required="1"/>
        
           <asp:Button 
        ID="btnBuscarDNI" 
        runat="server" 
        Text="Continuar" 
        CssClass="btn btn-outline-primary w-100" 
        style="height: 38px; margin-top: 8px;" 
        ValidationGroup="GrupoDNI"
        OnClick="btnBuscarDni_Click"
        OnClientClick="this.form.noValidate = true;" 
        />
</div>

                 <div class="mb-3">
    <label for="txtNombre" class="form-label">Nombre</label>
    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="" required="1" />

                     <div class="mb-3">
    <label for="txtApellido" class="form-label">Apellido</label>
    
    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="" required="1" />
</div>
</div>

                        <div class="mb-3">
    <label for="txtEmail" class="form-label">E-mail</label>

    <div class="input-group">
        <div class="input-group-text">@</div>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="" required="1" />
    </div>
</div>

<div class="mb-3">
    <label for="txtDireccion" class="form-label">Dirección</label>
    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="" required="1" />
    </div>
</div>
                    
                    <div class="mb-3">
                        <label for="txtCiudad" class="form-label">Ciudad</label>
                       
                        <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control" placeholder="Ciudad" required="1" />
                    </div>

                    <div class="mb-3">
    <label for="txtCp" class="form-label">Código Postal</label>
   
    <asp:TextBox ID="txtCp" runat="server" CssClass="form-control" placeholder="" required="1" />
</div>

     <asp:Button
         ID="btnParticipar"
         runat="server"
         Text="Participar"
         CssClass="btn btn-primary w-100"
         OnClientClick="return validarCheckbox();"
         OnClick="btnParticipar_Click"
         CausesValidation="true" />











    
</asp:Content>


