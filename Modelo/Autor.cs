using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Autor
    {
        int idAutor;
        string nombre;

        public Autor(int pIdAutor, string pNombre)
        {
            idAutor = pIdAutor;
            nombre = pNombre;
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
