using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //data tranfer objects
   public  class LibroDTO
    {
        string nombreEditorial;
        string tituloIsbn;
        string estado;
        bool disponibilidad;
        DateTime anioEdicion;

        public LibroDTO(string nombreEditorial, string tituloIsbn, string estado, bool disponibilidad, DateTime anioEdicion)
        {
            this.nombreEditorial = nombreEditorial;
            this.tituloIsbn = tituloIsbn;
            this.estado = estado;
            this.disponibilidad = disponibilidad;
            this.anioEdicion = anioEdicion;
        }

        public string NombreEditorial
        {
            get
            {
                return nombreEditorial;
            }

            set
            {
                nombreEditorial = value;
            }
        }

        public string TituloIsbn
        {
            get
            {
                return tituloIsbn;
            }

            set
            {
                tituloIsbn = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public bool Disponibilidad
        {
            get
            {
                return disponibilidad;
            }

            set
            {
                disponibilidad = value;
            }
        }

        public DateTime AnioEdicion
        {
            get
            {
                return anioEdicion;
            }

            set
            {
                anioEdicion = value;
            }
        }
    }
}
