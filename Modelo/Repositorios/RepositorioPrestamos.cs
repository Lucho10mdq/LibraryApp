using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public  class RepositorioPrestamos: Singleton<RepositorioPrestamos>
    {
        List<Prestamos> ListaPrestamos = new List<Prestamos>();
        static RepositorioPrestamos instance = null;

        public void AgregarPrestamo(Prestamos p)
        {
            ListaPrestamos.Add(p);
        }
        public void BorrarPrestamo(Prestamos p)
        {
            ListaPrestamos.Remove(p);
        }

        public List<Prestamos> DevolverPrestamos()
        {
            return ListaPrestamos;
        }

        
    }
}
