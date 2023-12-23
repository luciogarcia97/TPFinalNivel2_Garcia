using Dominio;
using Presentacion.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaService
    {
        public List<Categoria> listar()
        {
            List<Categoria>lista = new List<Categoria>();
            ArticuloDataAccess data = new ArticuloDataAccess();

            try
            {
                data.setQuery("select Id, Descripcion from CATEGORIAS");
                data.execute();

                while (data.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)data.Lector["Id"];
                    aux.Descripcion = (string)data.Lector["Descripcion"];

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
                data.close();
            }
        }
    }
}
