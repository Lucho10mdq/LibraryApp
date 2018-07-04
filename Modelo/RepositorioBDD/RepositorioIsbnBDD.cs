using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace Modelo
{
    public class RepositorioIsbnBDD:Singleton<RepositorioIsbnBDD>
    {
        private List<Isbn> ListaIsbnes = new List<Isbn>();
        static RepositorioIsbnBDD instance = null;
        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Biblioteca;Trusted_Connection=True;");

        public List<Isbn>ListaIsbn()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Listar_Isbnes";
            c.Prepare();
            SqlDataReader dn = c.ExecuteReader();
            while (dn.Read())
            {
                int IdEditorial = dn.GetInt32(1);
                string isbn = dn.GetString(2);
                DateTime anio = dn.GetDateTime(3);
                string titulo = dn.GetString(4);

                Isbn oIsbn = new Isbn(IdEditorial, titulo, isbn, anio);
                oIsbn.IdIsbn = dn.GetInt32(0);
                ListaIsbnes.Add(oIsbn);
            }
            dn.Close();
            conexion.Close();
            return ListaIsbnes;
        }
    }
}
