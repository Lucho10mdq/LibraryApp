using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Libro
    {
        DateTime anioEdicion;
        int IdEditorial;
        int idisbn;
        string estado;
        bool disponibilidad;
        int idLibro;

        public Libro(DateTime pAnioEdicion, int pIdEditorial, int pIdisbn, string pEstado, bool pDisponibilidad, int pIdlibro)
        {
            anioEdicion = pAnioEdicion;
            IdEditorial = pIdEditorial;
            idisbn = pIdisbn;
            estado = pEstado;
            disponibilidad = pDisponibilidad;
            idLibro = pIdlibro;

        }

        public int IdLibro
        {
            get
            {
                return idLibro;
            }
            set
            {
                idLibro = value;
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

        public int IdEditorial1
        {
            get
            {
                return IdEditorial;
            }

            set
            {
                IdEditorial = value;
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

        public int Idisnb
        {
            get
            {
                return idisbn;
            }
            set
            {
                idisbn = value;
            }
                
        }
    }

    

    
}
