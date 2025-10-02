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
            if (!IsPostBack)
            {
                ddlPartido.Items.Add(new ListItem("Seleccione un partido", ""));
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
                
                    if (Session["IdArticuloSeleccionado"] != null)
                    {
                        int id = (int)Session["IdArticuloSeleccionado"];
                        
                    }

            }

        }

        protected void cvTerminos_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = chkTerminos.Checked;
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Seleccion.aspx?", false);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            if (!Page.IsValid)
            {
                return; // Detiene la ejecución si hay errores de validación.
            }


            try
            {
                ClienteNegocio negocio = new ClienteNegocio();
                Cliente cliente = negocio.buscarPorDocumento(txtDocumento.Text);

                if (cliente == null)
                {
                    // Crear nuevo
                    cliente = new Cliente();
                    cliente.Documento = txtDocumento.Text;
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Partido = ddlPartido.SelectedValue.ToString();
                    cliente.CodigoPostal = int.Parse(txtCodigoPostal.Text);

                    negocio.agregar(cliente);
                }
                else
                {
                    // Modificar cliente existente
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Partido = ddlPartido.SelectedValue.ToString();
                    cliente.CodigoPostal = int.Parse(txtCodigoPostal.Text);

                    negocio.modificar(cliente);

                }

                Response.Redirect("CargaExitosa.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }



        }

        protected void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            string documento = txtDocumento.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                lblMensaje.Text = "Por favor, ingrese un DNI.";
                lblMensaje.Visible = true;
                return;
            }

            Cliente cliente = negocio.buscarPorDocumento(documento);

            if (cliente != null)
            {
                // Cliente encontrado precargo 
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEmail.Text = cliente.Email;
                txtDireccion.Text = cliente.Direccion;
                //ddlPartido.SelectedValue = cliente.Partido;
                txtCodigoPostal.Text = cliente.CodigoPostal.ToString();

                lblMensaje.Text = "Cliente encontrado. Puedes actualizar tus datos si es necesario.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Visible = true;
            }
            else
            {
                // Cliente NO encontrado mensaje
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                txtDireccion.Text = "";
                ddlPartido.ClearSelection();
                txtCodigoPostal.Text = "";

                lblMensaje.Text = "No estás registrado. Por favor completa tus datos.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
            }
        }



    }
}