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
            if (!IsPostBack) 
            {
                CargarArticulos();
            }
        }

        private void CargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            var articulos = negocio.listarArt();
            var imagenes = negocio.listarImagen();

            foreach (var art in articulos)
            {
                art.ImagenUrl = imagenes
                    .Where(img => img.IdArticulo == art.Id)
                    .Select(img => img.ImagenUrl)
                    .ToList();
            }
                        
            rptArticulos.DataSource = articulos;
            rptArticulos.DataBind();

        }

        protected void rptArticulos_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var rptImagenes = (Repeater)e.Item.FindControl("rptImagenes");
                var art = (Articulo)e.Item.DataItem;
                rptImagenes.DataSource = art.ImagenUrl;
                rptImagenes.DataBind();
            }
        }

        protected void btnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            int idArticulo;
            if (!int.TryParse(e.CommandArgument?.ToString(), out idArticulo))
                return;

            Session["IdArticuloSeleccionado"] = idArticulo;
                     
            Response.Redirect("DatosCliente.aspx", true);
        }



    }
        
        
    
}