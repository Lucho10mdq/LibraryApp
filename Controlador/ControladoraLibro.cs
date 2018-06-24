using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class ControladoraLibro
    {
       private  RepositorioLibros ListaLibros = RepositorioLibros.GetInstance();
        public void Agregar(DateTime YearEdicion,int Idedicion,int Idisbn,string estado,bool disponibilidad,int idlibro) 
        {
            Libro oLibro = new Libro(YearEdicion, Idedicion, Idisbn, estado, disponibilidad, idlibro);
            ListaLibros.AgregarLibro(oLibro);
        }

        public void Borra(Libro l)
        {
            ListaLibros.BorrarLibro(l);
        }

        public List<Libro> DevolverLibros()
        {
            return ListaLibros.DevolverLibros();
        }
    }
}
