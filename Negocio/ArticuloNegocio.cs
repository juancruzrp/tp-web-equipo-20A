using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;



namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, Precio, ImagenUrl from ARTICULOS A, IMAGENES I, MARCAS M, CATEGORIAS C where A.Id = I.IdArticulo and A.IdMarca = M.Id and A.IdCategoria = C.Id");
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, Precio, ImagenUrl, M.Id as IdMarca, C.Id as IdCategoria from ARTICULOS A, IMAGENES I, MARCAS M, CATEGORIAS C where A.Id = I.IdArticulo and A.IdMarca = M.Id and A.IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];

                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];

                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Marca.Id = (int)datos.Lector["IdMarca"];

                    aux.Categoria = new Categoria();
                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = Convert.ToDouble(datos.Lector["Precio"]);

                    //aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

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

        public List<Articulo> listarArt()
        {
            List<Articulo> lista= new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT Id, Nombre, Descripcion FROM ARTICULOS";
                
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                                       
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
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

        public List<Imagen> listarImagen()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT IdArticulo, ImagenUrl FROM IMAGENES";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen img = new Imagen();
                    img.IdArticulo = (int)datos.Lector["IdArticulo"];
                    img.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(img);
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


        public int agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(
                "insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                "values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio); " +
                "SELECT CAST(SCOPE_IDENTITY() AS INT);");

                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);

                int idGenerado = Convert.ToInt32(datos.ejecutarScalar());
                nuevo.Id = idGenerado;
                return idGenerado;

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

        public void agregarImagen(int idArticulo, string url)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into IMAGENES (IdArticulo, ImagenUrl) values (@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.setearParametro("@ImagenUrl", url);
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

        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo= @Codigo, Nombre=@Nombre, Descripcion=@Descripcion, IdMarca=@IdMarca, IdCategoria=@IdCategoria, Precio=@Precio where Id=@Id");
                datos.setearParametro("@Codigo", modificar.Codigo);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Descripcion", modificar.Descripcion);
                datos.setearParametro("@IdMarca", modificar.Marca.Id);
                datos.setearParametro("@IdCategoria", modificar.Categoria.Id);
                datos.setearParametro("@Precio", modificar.Precio);
                datos.setearParametro("@Id", modificar.Id);
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
               
        public void modificarImagen(int id, string nuevaUrl)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update IMAGENES set ImagenUrl=@ImagenUrl where IdArticulo=@Id");
                datos.setearParametro("@ImagenUrl", nuevaUrl);
                datos.setearParametro("@Id", id);
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
    
        public void eliminar(int id)
        {
                AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where id = @Id");
                datos.setearParametro("@Id", id);
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

        public void eliminarImagen(int id)
        {
                AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from IMAGENES where idarticulo = @Id");
                datos.setearParametro("@Id", id);
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

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, Precio, ImagenUrl, M.Id as IdMarca, C.Id as IdCategoria from ARTICULOS A, IMAGENES I, MARCAS M, CATEGORIAS C where A.Id = I.IdArticulo and A.IdMarca = M.Id and A.IdCategoria = C.Id and ";
                if (campo == "Precio")
                {
                    switch (criterio)
                    {

                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;

                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;

                        default:
                            consulta += "Precio = " + filtro;
                            break;

                    }
                   
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {

                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;

                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;

                    }

                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {

                        case "Comienza con":
                            consulta += "M.Descripcion like '" + filtro + "%' ";
                            break;

                        case "Termina con":
                            consulta += "M.Descripcion like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;

                    }

                }
                else
                {
                    switch (criterio)
                    {

                        case "Comienza con":
                            consulta += "C.Descripcion like '" + filtro + "%' ";
                            break;

                        case "Termina con":
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;

                    }

                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];

                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];

                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Marca.Id = (int)datos.Lector["IdMarca"];

                    aux.Categoria = new Categoria();
                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = Convert.ToDouble(datos.Lector["Precio"]);

                    ///aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
