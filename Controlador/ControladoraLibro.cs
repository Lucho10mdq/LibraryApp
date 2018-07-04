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
       private  RepositorioLibrosBDD ListaLibros = RepositorioLibrosBDD.GetInstance();
        public void Agregar(DateTime YearEdicion,int Idedicion,int Idisbn,string estado,bool disponibilidad) 
        {
            Libro oLibro = new Libro(YearEdicion, Idedicion, Idisbn, estado, disponibilidad);
            ListaLibros.AgregarLibro(oLibro);
        }

      /*  public void Borra(Libro l)
        {
            ListaLibros.BorrarLibro(l);
        }*/

        public List<LibroDTO> DevolverLibros()
        {
            return ListaLibros.ListarLibros();
        }
    }
}
