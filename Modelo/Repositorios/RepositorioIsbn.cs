using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioIsbn : Singleton<RepositorioIsbn>
    {
        private List<Isbn> ListaIsb = new List<Isbn>();
        static RepositorioIsbn instance = null;

        public void AgregarIsbn(Isbn i)
        {
            ListaIsb.Add(i);
        }

        public void BorrarIsbn(Isbn i)
        {
            ListaIsb.Remove(i);
        }

        public List<Isbn> DevolverTodosIsbn()
        {
            return ListaIsb;
        }

    }
}
