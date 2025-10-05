using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;
using System.Web.Services.Description;
using System.Drawing;
using System.Web.ModelBinding;

namespace TPPromoWeb_Equipo4B
{
    public partial class Default : System.Web.UI.Page
    {
        VoucherNegocio nv = new VoucherNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnComprobar(object sender, EventArgs e)
        {
            List<Voucher> listVoucher = new List<Voucher>();
            listVoucher = nv.Listar();
            int statusVoucher = nv.ComprobarVoucher(listVoucher, txtIngVoucher.Text);

            switch (statusVoucher)
            {
                case 2:
                    lblComprobacion.Text = "Voucher Correcto";
                    Session.Add("CodigoVoucher", txtIngVoucher.Text);
                    Response.Redirect("EleccionPremio.aspx", false);
                    break;
                case 1:
                    lblTitulo.Text = "Ingrese un nuevo codigo de voucher";
                    lblComprobacion.Text = "El voucher ingresado ya fue utilizado";
                    break;
                default:
                    lblComprobacion.Text = "El codigo de voucher ingresado no existe";
                    lblComprobacion.ForeColor = Color.Red;
                    lblTitulo.Text = "Ingrese el codigo de voucher nuevamente";
                    break;
            }
        }
    }
}