using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
               datos.setearConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion=(string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
            }
             
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;

        }



        public void agregar(Marca nueva) {

            AccesoDatos datos= new AccesoDatos ();

            try
            {
                datos.setearConsulta("INSERT INTO MARCAS(Descripcion) VALUES(@Descripcion)");
                datos.setearParametro("@Descripcion", nueva.Descripcion);
                datos.ejecutarAccion();
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

        public void modificar (Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE MARCAS SET Descripcion=@Descripcion WHERE Id=@Id");
                datos.setearParametro("@Descripcion", marca.Descripcion);
                datos.setearParametro("@Id", marca.Id); 

                datos.ejecutarAccion(); 

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

        public List<Marca> buscarPorNombre(string nombre)
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try

            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS WHERE Descripcion LIKE @nombre");
                datos.setearParametro("@nombre", "%" + nombre + "%");

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }

                return lista;

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

        public bool existeMarcaPorDescripcion(string descripcion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(1) FROM MARCAS WHERE Descripcion = @descripcion");
                datos.setearParametro("@descripcion", descripcion);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int count = (int)datos.Lector[0];
                    return count > 0;
                }
                return false;
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


        public void eliminarFisico(int id)
        {
            try
            {
                AccesoDatos acceso = new AccesoDatos();
                acceso.setearConsulta("DELETE FROM MARCAS where Id = @id");
                acceso.setearParametro("@id", id);
                acceso.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }


    }

