using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;
using System.Web.Services.Description;

namespace TPPromoWeb_Equipo4B
{
    public partial class Default : System.Web.UI.Page
    {
        VoucherNegocio listVoucher = new VoucherNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            listVoucher.Listar();
        }

        protected void btnComprobar(object sender, EventArgs e)
        {
            txtIngVoucher.Text = "Click1";
        }
    }
}