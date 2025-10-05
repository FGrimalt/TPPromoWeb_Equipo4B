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
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarPremios();
            /*
            if (!IsPostBack)
            {
                CargarPremios();
            }
            */
        }
        private void CargarPremios()
        {
            phPremios.Controls.Clear();

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> listaArticulos = articuloNegocio.Listar();

            foreach (Articulo articulo in listaArticulos)
            {
                string prImagen;
                
                if (!string.IsNullOrEmpty(articulo.Imagen[0].ImagenUrl))
                {
                    prImagen = articulo.Imagen[0].ImagenUrl;
                }
                else
                {
                    prImagen = "img/placeholder.png";
                }

                phPremios.Controls.Add(new LiteralControl($@"
        <div class='col-md-4 mb-4'>
            <div class='card h-100'>
                <img src='{prImagen}' class='card-img-top' alt='{articulo.Nombre}' />
                <div class='card-body text-center'>
                    <h5 class='card-title'>{articulo.Nombre}</h5>
                    <p class='card-text'>{articulo.Descripcion}</p>
                    <a href='IngresarDatos.aspx?id={articulo.Id}' class='btn btn-primary'>Elegir</a>
                </div>
            </div>
        </div>
    "));
            }
        }
    }
}
