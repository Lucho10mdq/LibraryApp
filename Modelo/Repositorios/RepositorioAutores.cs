using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
     public  class RepositorioAutores : Singleton<RepositorioAutores>
    {
        private List<Autor> ListaAutores = new List<Autor>();
        static RepositorioAutores instance = null;


        public void AgregarAutor(Autor a)
        {
            ListaAutores.Add(a);
        }

        public void BorrarAutor(Autor a)
        {
            ListaAutores.Remove(a);
        }

        public List<Autor> DevolverAutores()
        {
            return ListaAutores;
        }

        public Autor BuscarAutor(string nombre)
        {
            Autor aux = null;
            foreach (Autor a in ListaAutores)
            {
                if (a.Nombre == nombre)
                {
                    return a;
                }
            }
            return aux;
        }
    }
}
