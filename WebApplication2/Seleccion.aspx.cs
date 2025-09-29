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
        public List<Articulo> ListaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo = negocio.listarConSP();
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosCliente.aspx?", false);
        }
        /*
        protected void btnSeleccionar2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosCliente.aspx?", false);
        }

        protected void btnSeleccionar3_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosCliente.aspx?", false);
        }*/
    }
}