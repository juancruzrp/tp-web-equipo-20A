using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DatosCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        
        {
            ddlCiudad.Items.Add("Vicente López");
            ddlCiudad.Items.Add("San Isidro");
            ddlCiudad.Items.Add("San Fernando");
            ddlCiudad.Items.Add("Tigre");
            ddlCiudad.Items.Add("Escobar");
            ddlCiudad.Items.Add("Pilar");
            ddlCiudad.Items.Add("Malvinas Argentinas");
            ddlCiudad.Items.Add("José C. Paz");
            ddlCiudad.Items.Add("San Miguel");
            ddlCiudad.Items.Add("General San Martín");

        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Promocion.aspx?", false);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            /*  
             Crear conexion a la base de datos
             crear consulta
             setearla
             guardado de datos del registro de la persona
             actualizar la BD
            */
        }
    }
}