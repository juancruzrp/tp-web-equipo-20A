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
        Negocio.AccesoDatos datos = new Negocio.AccesoDatos();

        string query = "SELECT IdCliente FROM Vouchers WHERE CodigoVoucher = @codigo";
        SqlParameter[] parametros = { new SqlParameter("@codigo", txtCodigo.Text) };

        try
        {
            DataTable dt = datos.EjecutarConsulta(query, parametros);

            if (dt.Rows.Count == 0)
            {
                // No existe
                Response.Write("<script>alert('El código ingresado no es válido');</script>");
                return; // cortar ejecución
            }
            else if (dt.Rows[0]["IdCliente"] != DBNull.Value)
            {
                Response.Write("<script>alert('El voucher ya fue utilizado');</script>");
                return;
            }
            else
            {
                // Guardar voucher válido en sesión
                Session["CodigoVoucher"] = txtCodigo.Text;
                Response.Redirect("Seleccion.aspx", false);
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Ocurrió un error al procesar la solicitud.');</script>");
            // Opcional: log del error
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }
    }

}
}