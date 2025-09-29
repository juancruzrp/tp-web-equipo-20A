using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApplication2
{
    public partial class Promocion : System.Web.UI.Page
    {
        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Creamos una instancia de AccesoDatos
            //AccesoDatos datos = new AccesoDatos();
            

            // Por:
            Negocio.AccesoDatos datos = new Negocio.AccesoDatos();

            string query = "SELECT IdCliente FROM Vouchers WHERE CodigoVoucher = @codigo";
            SqlParameter[] parametros = { new SqlParameter("@codigo", txtCodigo.Text) };

            try
            {
                // metodo
                DataTable dt = datos.EjecutarConsulta(query, parametros);

                if (dt.Rows.Count == 0)
                {
                    // No existe
                    Response.Write("<script>alert('El código ingresado no es válido');</script>");
                }
                else if (dt.Rows[0]["IdCliente"] != DBNull.Value)
                {
                    
                    Response.Write("<script>alert('El voucher ya fue utilizado');</script>");
                }
                else
                {
                    // V ir a Seleccion.aspx
                    Session["CodigoVoucher"] = txtCodigo.Text; // guardo para usar después
                    Response.Redirect("Seleccion.aspx");
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores de la base de datos
                Response.Write("<script>alert('Ocurrió un error al procesar la solicitud.');</script>");
                // Opcional: registrar el error
                // Console.WriteLine(ex.ToString());
            }
        }
    }

}