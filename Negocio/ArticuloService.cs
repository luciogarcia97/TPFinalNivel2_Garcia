using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Presentacion.DataAccess;

namespace Negocio
{
    public class ArticuloService
    {
        public List<Articulo> listArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloDataAccess datos = new ArticuloDataAccess();

            try
            {
                datos.setQuery("select a.Id Id, a.Codigo Codigo, a.Nombre Nombre, a.Descripcion Descripcion, c.Descripcion Categoria, m.Descripcion Marca, a.Precio Precio, c.id idCategoria, m.Id idMarcas, a.ImagenUrl UrlImagen from ARTICULOS a left join CATEGORIAS c on c.Id = a.IdCategoria left join MARCAS m on m.Id = a.IdMarca");
                datos.execute();

                while (datos.Lector.Read())
                {
                    Articulo unit = new Articulo();

                    unit.Id = datos.Lector.GetInt32(0);
                    unit.Codigo = (string)datos.Lector["Codigo"];
                    unit.Nombre = (string)datos.Lector["Nombre"];
                    unit.Descripcion = (string)datos.Lector["Descripcion"];
                    unit.Categoria = new Categoria();
                    unit.Categoria.Id = (int)datos.Lector["idCategoria"];
                    unit.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    unit.Marca = new Marca();
                    unit.Marca.Id = (int)datos.Lector["idMarcas"];
                    unit.Marca.Descripcion = (string)datos.Lector["Marca"];
                    unit.UrlImagen = (string)datos.Lector["UrlImagen"];
                    unit.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(unit);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.close();
            }

        }
        public void modificarArticulo(Articulo item)
        {
            ArticuloDataAccess data = new ArticuloDataAccess();
            try
            {
                data.setQuery("UPDATE articulos SET codigo = @Codigo@, nombre = @Nombre@, descripcion = @Descripcion@, idMarca = @Marca@, idCategoria = @Categoria@, ImagenUrl = @ImagenUrl@, precio = @Precio@ WHERE Id = @ID@;");

                data.setParameters("@ID@", item.Id);
                data.setParameters("@codigo@",item.Codigo);
                data.setParameters("@nombre@", item.Nombre);
                data.setParameters("@descripcion@", item.Descripcion);
                data.setParameters("@marca@", item.Marca.Id);
                data.setParameters("@categoria@", item.Categoria.Id);
                data.setParameters("@ImagenUrl@",item.UrlImagen);
                data.setParameters("@precio@",item.Precio);

                data.execute();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            finally
            {
                data.close();
            }
        }
        public void agregarArticulo(Articulo item)
        {
            ArticuloDataAccess data = new ArticuloDataAccess();

            try
            {
                data.setQuery("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@codigo@,@nombre@,@descripcion@,@marca@,@categoria@,@imagen@,@precio@);");

                data.setParameters("@codigo@",item.Codigo);
                data.setParameters("@nombre@", item.Nombre);
                data.setParameters("@descripcion@", item.Descripcion);
                data.setParameters("@marca@", item.Marca.Id);
                data.setParameters("@categoria@", item.Categoria.Id);
                data.setParameters("@imagen@",item.UrlImagen);
                data.setParameters("@precio@",item.Precio);

                data.execute();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            { 
                data.close(); 
            }
        }
        public List<Articulo> filtrar(int precio_minimo, int precio_maximo, string marca, string categoria)
        {
            List<Articulo> list = new List<Articulo>();
            ArticuloDataAccess data = new ArticuloDataAccess();

            try
            {
                string query = "select a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion as Marca, c.Descripcion as Categoria, a.ImagenUrl, a.Precio, a.IdCategoria, a.IdMarca from ARTICULOS a left join MARCAS m on m.Id = a.IdMarca left join CATEGORIAS c on c.id = a.IdCategoria";

                if (precio_minimo == -1)
                {
                    if (precio_maximo == -1)
                    {
                        if (!string.IsNullOrEmpty(marca))
                        {
                            query += " where m.Descripcion like '%' + @filterMarca + '%'";
                        }
                        if (!string.IsNullOrEmpty(categoria))
                        {
                            query += " where c.Descripcion like '%' + @filterCategoria + '%'";
                        }
                    }
                    else
                    {
                        query += " where a.Precio < @filterPrecioMax";
                        if (!string.IsNullOrEmpty(marca))
                        {
                            query += " and m.Descripcion like '%' + @filterMarca + '%'";
                        }
                        if (!string.IsNullOrEmpty(categoria))
                        {
                            query += " and c.Descripcion like '%' + @filterCategoria + '%'";
                        }
                    }
                }
                else
                {
                    query += " where a.Precio > @filterPrecioMin";
                    if (precio_maximo == -1)
                    {
                        if (!string.IsNullOrEmpty(marca))
                        {
                            query += " and m.Descripcion like '%' + @filterMarca + '%'";
                        }
                        if (!string.IsNullOrEmpty(categoria))
                        {
                            query += " and c.Descripcion like '%' + @filterCategoria + '%'";
                        }
                    }
                    else
                    {
                        query += " and a.Precio < @filterPrecioMax";
                        if (!string.IsNullOrEmpty(marca))
                        {
                            query += " and m.Descripcion like '%' + @filterMarca + '%'";
                        }
                        if (!string.IsNullOrEmpty(categoria))
                        {
                            query += " and c.Descripcion like '%' + @filterCategoria + '%'";
                        }
                    }
                }
                query += " order by a.id asc";

                data.setQuery(query);
                data.setParameters("@filterPrecioMin",precio_minimo);
                data.setParameters("@filterPrecioMax",precio_maximo);
                data.setParameters("@filterMarca",marca);
                data.setParameters("@filterCategoria",categoria);

                data.execute();
                while (data.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)data.Lector.GetInt32(0);
                    aux.Codigo = (string)data.Lector["Codigo"];
                    aux.Nombre = (string)data.Lector["Nombre"];
                    aux.Descripcion = (string)data.Lector["Descripcion"];
                    if(!(data.Lector["ImagenUrl"] is DBNull)) aux.UrlImagen = (string)data.Lector["ImagenUrl"];
                    aux.Precio = (decimal)data.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)data.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)data.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)data.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)data.Lector["Categoria"];

                    list.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                data.close();
            }
            
            return list;
        }
    }
}
