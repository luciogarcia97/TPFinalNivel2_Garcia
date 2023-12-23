using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.DataAccess
{
    public class ArticuloDataAccess
    {
        private SqlConnection conexion;
        private SqlCommand command;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public ArticuloDataAccess()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            command = new SqlCommand();
        }

        public void setQuery(string Query)
        {
            command.Parameters.Clear(); // Con esto limpiamos el comando
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = Query;
        }

        public void execute()
        {
            command.Connection = conexion;
            try
            {
                conexion.Open();
                lector = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void close()
        {
            if(lector != null)
                lector.Close();
            conexion.Close();
        }
        public void setParameters(string name, object value)
        {
            command.Parameters.AddWithValue(name, value);
        }
    }

}
