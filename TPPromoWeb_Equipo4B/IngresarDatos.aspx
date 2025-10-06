<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePromo.Master" AutoEventWireup="true" CodeBehind="IngresarDatos.aspx.cs" Inherits="TPPromoWeb_Equipo4B.IngresarDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script>

        function validarCampos() {
            const campos = [
                '<%= txtNombre.ClientID %>',
                '<%= txtApellido.ClientID %>',
                '<%= txtEmail.ClientID %>',
                '<%= txtDireccion.ClientID %>',
                '<%= txtCiudad.ClientID %>',
                '<%= txtCp.ClientID %>'
             ];

             const boton = document.getElementById('<%= btnParticipar.ClientID %>');
            let todosCompletos = true;

            campos.forEach(id => {
                const campo = document.getElementById(id);
                if (!campo || campo.value.trim() === '') {
                    todosCompletos = false;
                }
            });

            boton.disabled = !todosCompletos;
        }

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
        } ///
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div></div>
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <h2 id="aspnetTitle" class="mb-4">Ingresar Datos: </h2>

                <div class="mb-3 row">
                    <div class="col-md-8">
                        <label for="txtDNI" class="form-label">DNI</label>

                        <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" placeholder="ingrese DNI" type="text" required="1" />
                        <asp:RegularExpressionValidator ErrorMessage="El DNI debe contener solo números sin puntos ni espacios." ControlToValidate="txtDNI" ValidationExpression="^[0-9]+$" ForeColor="Red" runat="server" />

                        <asp:Button
                            ID="btnBuscarDNI"
                            runat="server"
                            Text="Validar"
                            CssClass="btn btn-primary w-100"
                            Style="height: 38px; margin-top: 8px;"
                            ValidationGroup="GrupoDNI"
                            OnClick="btnBuscarDni_Click"
                            OnClientClick="this.form.noValidate = true;" />

                        <asp:Label
                            ID="lblMensaje"
                            runat="server"
                            ForeColor="Green"
                            CssClass="mt-2 d-block">
                        </asp:Label>
                    </div>

                    <div class="mb-3">
                        <label for="txtNombre" class="form-label">Nombre</label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Enabled="false" oninput="validarCampos()" />
                        <asp:RegularExpressionValidator ErrorMessage="Solo se permiten letras." ControlToValidate="txtNombre" ValidationExpression="^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$" ForeColor="Red" runat="server" />

                        <div class="mb-3">
                            <label for="txtApellido" class="form-label">Apellido</label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" Enabled="false" oninput="validarCampos()" />
                            <asp:RegularExpressionValidator ErrorMessage="Solo se permiten letras." ControlToValidate="txtApellido" ValidationExpression="^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$" ForeColor="Red" runat="server" />
                        </div>
                    </div>

                    <div class="mb-3">
                        <label for="txtEmail" class="form-label">E-mail</label>
                        <div class="input-group">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Enabled="false" oninput="validarCampos()" />
                            <asp:RegularExpressionValidator ErrorMessage="Ingrese un email válido." ControlToValidate="txtEmail" ValidationExpression="^([\w-\.]+)@(([0−9]1,3\.[0−9]1,3\.[0−9]1,3\.)|(([\w−]+\.)+))([a−zA−Z]2,4|[0−9]1,3)(
?)$" ForeColor="Red" runat="server" />
                        </div>
                    </div>
                    <div class="mb-3">
                        <label for="txtDireccion" class="form-label">Dirección</label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" Enabled="false" oninput="validarCampos()" />
                    </div>
                </div>

                <div class="mb-3">
                    <label for="txtCiudad" class="form-label">Ciudad</label>
                    <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control" Enabled="false" oninput="validarCampos()" />
                    <asp:RegularExpressionValidator ErrorMessage="Solo se permiten letras." ControlToValidate="txtCiudad" ValidationExpression="^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$" ForeColor="Red" runat="server" />
                </div>

                <div class="mb-3">
                    <label for="txtCp" class="form-label">Código Postal</label>
                    <asp:TextBox ID="txtCp" runat="server" CssClass="form-control" Enabled="false" oninput="validarCampos()" />
                </div>

                <asp:Button
                    ID="btnParticipar"
                    runat="server"
                    Text="Participar"
                    CssClass="btn btn-success w-100"
                    Enabled="false"
                    OnClientClick="return validarCheckbox();"
                    OnClick="btnParticipar_Click"
                    CausesValidation="true" />
</asp:Content>


