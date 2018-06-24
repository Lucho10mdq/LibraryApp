using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Creadores
    {
        int idAutor;
        int idLibro;
        DateTime anioEscrito;

        public Creadores(int pIdAutor, int pIdLibro, DateTime pAnioEscrito)
        {
            idAutor = pIdAutor;
            idLibro = pIdLibro;
            anioEscrito = pAnioEscrito;
        }

        public int IdAutor
        {
            get
            {
                return idAutor;
            }

            set
            {
                idAutor = value;
            }
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

        public DateTime AnioEscrito
        {
            get
            {
                return anioEscrito;
            }

            set
            {
                anioEscrito = value;
            }
        }
    }
}
