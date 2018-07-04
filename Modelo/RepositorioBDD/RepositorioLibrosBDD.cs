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
   public  class RepositorioLibrosBDD:Singleton<RepositorioLibrosBDD>
    {
        private List<LibroDTO> ListaLibros = new List<LibroDTO>();
        static RepositorioLibrosBDD instance = null;
        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Biblioteca;Trusted_Connection=True;");

        //AGREGAR LIBRO
        public Libro AgregarLibro(Libro oLibro)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Agregar_Libro";
            c.Parameters.AddWithValue("anioEdicion", oLibro.AnioEdicion);
            c.Parameters.AddWithValue("idEditorial", oLibro.IdEditorial1);
            c.Parameters.AddWithValue("idIsbn", oLibro.Idisnb);
            c.Parameters.AddWithValue("estado", oLibro.Estado);
            c.Parameters.AddWithValue("disponibilidad", oLibro.Disponibilidad);
            SqlDataReader dn = c.ExecuteReader();
            if (dn.Read())
                oLibro.IdLibro = dn.GetInt32(0);
            return oLibro;
            dn.Close();
            conexion.Close();
        }

        public List<LibroDTO> ListarLibros()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Listar_Libros";
            c.Prepare();
            SqlDataReader dn = c.ExecuteReader();
            while(dn.Read())
            {
                var a = dn.GetDateTime(1);
                string nombreEditorial = dn.GetString(2);
                string nombreIsbn = dn.GetString(3);
                string estado = dn.GetString(4);
                bool disponibilidad = dn.GetBoolean(5);
                LibroDTO oLibroDTO = new LibroDTO(nombreEditorial, nombreIsbn, estado, disponibilidad, a);
                ListaLibros.Add(oLibroDTO);
                dn.Close();
                conexion.Close();
            }
            return ListaLibros;
        }

    }
}
