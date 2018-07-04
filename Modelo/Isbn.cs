using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Isbn
    {
        int idEditorial;
        string titulo;
        int idIsbn;
        string nisbn;
        DateTime anio;

        public Isbn(int pIdEditorial, string pTitulo,string pIsbn,DateTime pAnio)
        {
            idEditorial = pIdEditorial;
            titulo = pTitulo;
            nisbn = pIsbn;
            anio = pAnio;
        }


        public string Nisbn
        {
            get
            {
                return nisbn;
            }
            set
            {
                nisbn = value;
            }
        }
        public int IdEditorial
        {
            get
            {
                return idEditorial;
            }

            set
            {
                idEditorial = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public int IdIsbn
        {
            get
            {
                return idIsbn;
            }

            set
            {
                idIsbn = value;
            }
        }

        public DateTime Anio
        {
            get
            {
                return anio;
            }

            set
            {
                anio = value;
            }
        }
    }
}
