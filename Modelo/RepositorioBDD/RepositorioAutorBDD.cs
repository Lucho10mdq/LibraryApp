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
    public class RepositorioAutorBDD:Singleton<RepositorioAutorBDD>
    {
        private List<Autor> ListaAutores = new List<Autor>();
        static RepositorioAutorBDD instance = null;

        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Biblioteca;Trusted_Connection=True;");

        //AGREAR AUTOR

        public Autor AgregarAutor(Autor oAutor)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Agregar_Autor";
            c.Parameters.AddWithValue("nombre", oAutor.Nombre);
            SqlDataReader dn = c.ExecuteReader();
            if (dn.Read())
                oAutor.IdAutor = dn.GetInt32(0);
            return oAutor;
            dn.Close();
            conexion.Close();
        }

        //LISTA AUTORES

        public List<Autor> DevolverAutores()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Listar_Autores";
            c.Prepare();
            SqlDataReader dn = c.ExecuteReader();
            while(dn.Read())
            {
                string nombre = dn.GetString(1);
                Autor oAutor = new Autor(nombre);
                oAutor.IdAutor = dn.GetInt32(0);
                ListaAutores.Add(oAutor);
            }
            dn.Close();
            conexion.Close();
            return ListaAutores;
        }
        //BUSCAR AUTORES

        public Autor BuscarAutor(string nombre)
        {
            Autor oAutor = null;
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Buscar_Autor";
            SqlParameter NombreParameter = c.CreateParameter();
            NombreParameter.ParameterName = "@nombre";
            NombreParameter.SqlDbType = SqlDbType.VarChar;
            NombreParameter.Value = nombre;
            c.Parameters.Add(NombreParameter);
            SqlDataReader dn = c.ExecuteReader();
            while (dn.Read())
            {
                string nombres = dn.GetString(1);
                oAutor = new Autor(nombres);
                oAutor.IdAutor = dn.GetInt32(0);
            }
            dn.Close();
            conexion.Close();
            return oAutor;
        }
    }
}
