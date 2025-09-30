using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebApplication2
{
    public partial class DatosCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            ddlPartido.Items.Add("Vicente López");
            ddlPartido.Items.Add("San Isidro");
            ddlPartido.Items.Add("San Fernando");
            ddlPartido.Items.Add("Tigre");
            ddlPartido.Items.Add("Escobar");
            ddlPartido.Items.Add("Pilar");
            ddlPartido.Items.Add("Malvinas Argentinas");
            ddlPartido.Items.Add("José C. Paz");
            ddlPartido.Items.Add("San Miguel");
            ddlPartido.Items.Add("General San Martín");

        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Seleccion.aspx?", false);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!chkTerminos.Checked)
            {
                // Validación simple
                Response.Write("<script>alert('Debes aceptar los términos y condiciones.');</script>");
                return;
            }
            ClienteNegocio negocio = new ClienteNegocio();


            try
            {
                
                Cliente cliente = new Cliente();
                
                cliente.DNI = int.Parse(txtDNI.Text);
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Email = txtEmail.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Partido = ddlPartido.SelectedIndex.ToString();
                cliente.CodigoPostal = int.Parse(txtCodigoPostal.Text);

                
            }
            catch (Exception ex)
            {

                throw;
            }




        }

    }
}