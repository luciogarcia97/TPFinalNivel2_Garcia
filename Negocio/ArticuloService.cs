using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
