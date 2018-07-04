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
     public class RepositorioSociosBDD : Singleton<RepositorioSociosBDD>
    {
        private List<Socios> listaSocios = new List<Socios>();
        static RepositorioSociosBDD instance = null;

        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Biblioteca;Trusted_Connection=True;");

        //Agregar Socio
        public Socios Agregar(Socios oSocio)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Agregar_Socio";
            c.Parameters.AddWithValue("apellido", oSocio.Apellido);
            c.Parameters.AddWithValue("nombre", oSocio.Nombre);
            c.Parameters.AddWithValue("dni", oSocio.Dni);
            c.Parameters.AddWithValue("direccion", oSocio.Direccion);
            c.Parameters.AddWithValue("telefono", oSocio.Telefono);
            SqlDataReader dn = c.ExecuteReader();
            if (dn.Read())
                oSocio.IdSocios = dn.GetInt32(0);
                return oSocio;
            dn.Close();
            conexion.Close();
        }

        //LISTAR SOCIOS
        public List<Socios> DeVolverTodosLosSocios()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Listar_Socios";
            c.Prepare();
            SqlDataReader dn = c.ExecuteReader();
            while (dn.Read())
            {
                string apellido = dn.GetString(1);
                string dni = dn.GetString(2);
                string direccion = dn.GetString(3);
                string telefono = dn.GetString(4);
                string nombre = dn.GetString(5);
                Socios oSocio = new Socios(dni, direccion, telefono, apellido, nombre);
                oSocio.IdSocios = dn.GetInt32(0);
                listaSocios.Add(oSocio);
            }
            dn.Close();
                conexion.Close();
            return listaSocios;
        }
        //BUSCAR SOCIO POR APELLIDO
        public Socios BuscarSocoioPorApellido(string pApellido)
        {
            Socios oSocio = null;
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Buscar_Socio";
            SqlParameter ApellidoParameter = c.CreateParameter();
            ApellidoParameter.ParameterName = "@Apellido";
            ApellidoParameter.SqlDbType = SqlDbType.VarChar;
            ApellidoParameter.Value = pApellido;
            c.Parameters.Add(ApellidoParameter);
            SqlDataReader dn = c.ExecuteReader();
            while (dn.Read())
            {
                string apellido = dn.GetString(1);
                string dni = dn.GetString(2);
                string direccion = dn.GetString(3);
                string telefono = dn.GetString(4);
                string nombre = dn.GetString(5);
                oSocio = new Socios(dni, direccion, telefono, apellido, nombre);
                oSocio.IdSocios = dn.GetInt32(0);    
            }
            dn.Close();
            conexion.Close();
            return oSocio;
        }
        //ELIMINAR SOCIO
       public int EliminarSocioPorDni(string dni)
        {
            Socios s = null;
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Borrar_Socio";
            SqlParameter DniParameter = c.CreateParameter();
            DniParameter.ParameterName = "@Dni";
            DniParameter.SqlDbType = SqlDbType.VarChar;
            DniParameter.Value = dni;
            c.Parameters.Add(DniParameter);
            int affectedRows = c.ExecuteNonQuery();
            conexion.Close();
            return affectedRows;
        }
    }
}
