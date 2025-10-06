using System;
using System.Web.UI.WebControls;
using System.Web.UI;
using negocio;
using dominio;
using System.Collections.Generic;


namespace TPPromoWeb_Equipo4B
{
    public partial class EleccionPremio : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos = null;
        protected void Page_Load(object sender, EventArgs e)
        {   
            if (!IsPostBack)
            {
                ArticuloNegocio articuloNegocioAux = new ArticuloNegocio();
                listaArticulos = articuloNegocioAux.Listar();
            }
            
        }
        
    }
}
