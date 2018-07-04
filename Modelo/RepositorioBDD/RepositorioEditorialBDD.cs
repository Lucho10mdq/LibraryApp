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
   public  class RepositorioEditorialBDD:Singleton<RepositorioEditorialBDD>
     {
        private List<Editoriales> ListaEditoriales = new List<Editoriales>();
        static RepositorioEditorialBDD instance = null;

        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Biblioteca;Trusted_Connection=True;");

        //AGREGAR EDITORIAL

        public Editoriales AgregarEditorial(Editoriales oEditoriales)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Guardar_Editoriales";
            c.Parameters.AddWithValue("nombre", oEditoriales.Nombre);
            SqlDataReader dn = c.ExecuteReader();
            if (dn.Read())
                oEditoriales.IdEditorial = dn.GetInt32(0);
            return oEditoriales;
            dn.Close();
            conexion.Close();
        }

        //LISTAR EDITORIALES
        public List<Editoriales> ListarEditoriales()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Listar_Editoriales";
            c.Prepare();
            SqlDataReader dn = c.ExecuteReader();
            while(dn.Read())
            {
                string nombre = dn.GetString(1);
                Editoriales oEditorial = new Editoriales(nombre);
                oEditorial.IdEditorial = dn.GetInt32(0);
                ListaEditoriales.Add(oEditorial);
            }
            dn.Close();
            conexion.Close();
            return ListaEditoriales;
        }

        //BUSCAR EDITORIAL

        public Editoriales BuscarEditorial(string nombre)
        {
            Editoriales oEditorial = null;
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Buscar_Editorial";
            SqlParameter NombreParameter = c.CreateParameter();
            NombreParameter.ParameterName = "@nombre";
            NombreParameter.SqlDbType = SqlDbType.VarChar;
            NombreParameter.Value = nombre;
            c.Parameters.Add(NombreParameter);
            SqlDataReader dn = c.ExecuteReader();
            while (dn.Read())
            {
                string nombres = dn.GetString(1);
                oEditorial = new Editoriales(nombres);
                oEditorial.IdEditorial = dn.GetInt32(0);

            }
            dn.Close();
            conexion.Close();
            return oEditorial;
        }
    }
}
