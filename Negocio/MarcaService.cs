using Dominio;
using Presentacion.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaService
    {
        public List<Marca> listar()
        {
			List<Marca> lista = new List<Marca>();
			ArticuloDataAccess data = new ArticuloDataAccess();

			try
			{
				data.setQuery("select Id, Descripcion from MARCAS");
				data.execute();

				while (data.Lector.Read())
				{
					Marca aux = new Marca();
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
