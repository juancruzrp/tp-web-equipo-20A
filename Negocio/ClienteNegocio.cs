using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Negocio
{
    public class ClienteNegocio
    {
        public int agregar(Cliente nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(
                "Insert into Clientes(Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " +
                "values(@DNI, @Nombre, @Apellido, @Email, @Direccion, @Partido, @CodigoPostal); "+
                "SELECT CAST(SCOPE_IDENTITY() AS INT);");

                datos.setearParametro("@DNI",nuevo.DNI); 
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Email", nuevo.Email);
                datos.setearParametro("@Direccion", nuevo.Direccion);
                datos.setearParametro("@Ciudad", nuevo.Partido);
                datos.setearParametro("@CodigoPostal", nuevo.CodigoPostal);

                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}
