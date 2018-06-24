using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class ControladoraPrestamo
    {
       private  RepositorioPrestamos ListaPrestamos = RepositorioPrestamos.GetInstance();

        public void AgregarPrestamo(int idLibro,int idSocio, DateTime hoy,DateTime nulo, int valor, DateTime devolucion)
        {
            Prestamos oPrestamo= new Prestamos(idLibro, idSocio, DateTime.Now, Convert.ToDateTime(null), 20, DateTime.Now.AddDays(15));
           ListaPrestamos.AgregarPrestamo(oPrestamo);
        }

        public List<Prestamos>DevolverTodos()
        {
            return ListaPrestamos.DevolverPrestamos();
        }
    }
}
