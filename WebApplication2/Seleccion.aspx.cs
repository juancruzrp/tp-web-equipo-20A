using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Seleccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionar1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosCliente.aspx?", false);
        }

        protected void btnSeleccionar2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosCliente.aspx?", false);
        }

        protected void btnSeleccionar3_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosCliente.aspx?", false);
        }
    }
}