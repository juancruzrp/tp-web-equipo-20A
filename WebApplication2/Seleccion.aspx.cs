using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebApplication2
{
    public partial class Seleccion : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; } = new List<Articulo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //ArticuloNegocio negocio = new ArticuloNegocio();
            // ListaArticulo = negocio.listarConSP();
            if (!IsPostBack) 
            {
                CargarArticulos();
            }
        }

        private void CargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            var articulos = negocio.listarConSP();
            var imagenes = negocio.listarImagen();

            foreach (var art in articulos)
            {
                art.ImagenUrl = imagenes
                    .Where(img => img.IdArticulo == art.Id)
                    .Select(img => img.ImagenUrl)
                    .ToList();
            }

            ListaArticulo = articulos;
        }


        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosCliente.aspx?", false);
        }
        
    }
}