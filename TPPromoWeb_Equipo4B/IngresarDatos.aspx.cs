using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPPromoWeb_Equipo4B
{
    public partial class IngresarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
         {

        }

        protected void btnBuscarDni_Click(object sender, EventArgs e)
        {
            // VALIDAMOS QUE NO ESTE VACIO EL DNI 
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "DNI OBLIGATORIO ";
                return;
            }

            try
            {
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                int dni = Convert.ToInt32(EliminarPuntos(txtDNI.Text.Trim()));

                Clientes clientes = clienteNegocio.ChequearDNI(dni);

                //BUSCAMOS QUE EL CLIENTE EXISTA 
                if (clientes != null)
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    lblMensaje.Text = "EL CLIENTE YA ESTA REGISTRADO. DATOS CARGADOS";

                    txtNombre.Text = clientes.Nombre;
                    txtApellido.Text = clientes.Apellido;
                    txtEmail.Text = clientes.Email;
                    txtDireccion.Text = clientes.Direccion;
                    txtCiudad.Text = clientes.Ciudad;
                    txtCp.Text = clientes.CP.ToString();

            
                    txtDNI.Enabled = false;

                    
                    btnParticipar.Enabled = true;
                }
                else
                {
                    //SI EL CLIENTE NO EXISTE HABILITAMOS PARA QUE ESCRIBA
                    lblMensaje.ForeColor = System.Drawing.Color.OrangeRed;
                    lblMensaje.Text = "NO ESTA REGISTRADO. INGRESE LOS DATOS";

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtEmail.Text = "";
                    txtDireccion.Text = "";
                    txtCiudad.Text = "";
                    txtCp.Text = "";

                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtEmail.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCiudad.Enabled = true;
                    txtCp.Enabled = true;
                    btnParticipar.Enabled = true;

                    txtDNI.Enabled = false; 
                }
            }
            catch (FormatException)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "EL FORMATO ES INCORRECTO, SOLO NUMEROS";
            }
            catch (Exception ex)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "ERROR AL VALIDAR DNI " + ex.Message;
            }
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Clientes cliente = clienteNegocio.ChequearDNI(Convert.ToInt32(EliminarPuntos(txtDNI.Text)));
                
            if (cliente == null)
            {
                cliente = new Clientes();
                cliente.Documento = EliminarPuntos(txtDNI.Text);
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Email = txtEmail.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Ciudad = txtCiudad.Text;
                if (int.TryParse(txtCp.Text.Trim(), out int codigoPostal))
                {
                    cliente.CP = codigoPostal;
                }
                else
                {
                    // Manejo de error si el campo no es numérico
                    lblMensaje.Text = "El Código Postal debe ser un número válido.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return; // Detiene el proceso y no continúa con el registro
                }
                cliente.Id = clienteNegocio.agregar(cliente);

                Session["NombreCliente"] = cliente.Nombre;
                Response.Redirect("participacionExitosa.aspx");
            }
        }

        private string EliminarPuntos(string dni)
        {
            return dni.Replace(".", "");
        }


    }
}