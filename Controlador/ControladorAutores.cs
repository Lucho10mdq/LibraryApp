using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
     public class ControladorAutores
    {
        private RepositorioAutorBDD ListaAutores = RepositorioAutorBDD.GetInstance();

        public bool AgregarAutor(string nombreCompleto)
        {
            var result = false;
            Autor oAutor = new Autor(nombreCompleto);

           /* if(ListaAutores.BuscarAutor(nombreCompleto)==null)
            {
                ListaAutores.AgregarAutor(oAutor);
                result = true;
            }*/
            ListaAutores.AgregarAutor(oAutor);
            result = true;
            return result;
           
        }

        /* public void BorrarAutor(Autor a)
         {
             ListaAutores.BorrarAutor(a);
         }*/

         public Autor BuscarAutorPorNombre(string nombre)
         {
           return  ListaAutores.BuscarAutor(nombre);

         }
        public List<Autor> DevolverAutores()
        {
            return ListaAutores.DevolverAutores();
        }

    }
}
