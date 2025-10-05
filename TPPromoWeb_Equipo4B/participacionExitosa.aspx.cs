using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPPromoWeb_Equipo4B
{
    public partial class participacionExitosa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string nombreCliente;

                if (Session["NombreCliente"] != null)
                {
                    nombreCliente = Session["NombreCliente"].ToString();
                }
                else
                {
                    nombreCliente = "capo";
                }

                lblMensajeExitoso.Text = $"¡Gracias {nombreCliente}, tu participación se registró correctamente.";
            }
        }
    }
}