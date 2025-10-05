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
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            Clientes clientes = clienteNegocio.ChequearDNI(Convert.ToInt32(EliminarPuntos(txtDNI.Text)));

            if (clientes != null)
            {
                lblMensaje.Text = "Cliente encontrado. Datos cargados automáticamente.";

                txtNombre.Text = clientes.Nombre;
                txtApellido.Text = clientes.Apellido;
                txtEmail.Text = clientes.Email;
                txtDireccion.Text = clientes.Direccion;
                txtCiudad.Text = clientes.Ciudad;
                txtCp.Text = clientes.CP.ToString();

                txtDNI.Enabled = false; //BLOQUEO EL DNI PARA QUE NO LO EDITEN/CAMBIEN.
            }
            else
            {
                lblMensaje.Text = "No se encontró el DNI. Complete los datos.";

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                txtDireccion.Text = "";
                txtCiudad.Text = "";
                txtCp.Text = "";
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
            cliente.CP = int.Parse(txtCp.Text);
            cliente.Id = clienteNegocio.agregar(cliente);
        }
    }

    private string EliminarPuntos(string dni)
    {
        return dni.Replace(".", "");
    }
}
}