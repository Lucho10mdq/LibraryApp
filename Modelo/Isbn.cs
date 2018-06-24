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
        int nisbn;

        public Isbn(int pIdEditorial, string pTitulo, int pIdIsbn, int pIsbn)
        {
            idEditorial = pIdEditorial;
            titulo = pTitulo;
            idIsbn = pIdIsbn;
            nisbn = pIsbn;
        }


        public int Nisbn
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
    }
}
