using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Editoriales
    {
        int idEditorial;
        string nombre;

        public Editoriales(int pIdEditorial, string pNombre)
        {
            idEditorial = pIdEditorial;
            nombre = pNombre;
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
