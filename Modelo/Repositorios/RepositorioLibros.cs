using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioLibros : Singleton<RepositorioLibros>
    {
        private List<Libro> ListaLibros = new List<Libro>();
        static RepositorioLibros instance = null;

        public void AgregarLibro(Libro l)
        {
            ListaLibros.Add(l);

        }

        public void BorrarLibro(Libro l)
        {
            ListaLibros.Remove(l);
        }

        public List<Libro> DevolverLibros()
        {
            return ListaLibros;
        }
    }
}
