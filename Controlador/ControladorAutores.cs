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
        private RepositorioAutores ListaAutores = RepositorioAutores.GetInstance();

        public bool AgregarAutor(int idAutor,string nombreCompleto)
        {
            var result = false;
            Autor oAutor = new Autor(idAutor, nombreCompleto);

            if(ListaAutores.BuscarAutor(nombreCompleto)==null)
            {
                ListaAutores.AgregarAutor(oAutor);
                result = true;
            }
            return result;
           
        }

        public void BorrarAutor(Autor a)
        {
            ListaAutores.BorrarAutor(a);
        }

        public List<Autor>DevolverAutores()
        {
           return ListaAutores.DevolverAutores();
        }

        public Autor BuscarAutorPorNombre(string nombre)
        {
          return  ListaAutores.BuscarAutor(nombre);

        }

    }
}
