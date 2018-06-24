using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
  public  class Socios
    {
        private int idSocios;
        private string dni;
        private string direccion;
        private string telefono;
        private string apellido;
        private string nombre;

        public Socios( string pDni, string pDireccion, string pTelefono, string pApellido, string pNombre)
        {
           
            Dni = pDni;
            Direccion = pDireccion;
            Telefono = pTelefono;
            Apellido = pApellido;
            Nombre = pNombre;

        }

        public int IdSocios
        {
            get
            {
                return idSocios;
            }

            set
            {
                idSocios = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }
}
