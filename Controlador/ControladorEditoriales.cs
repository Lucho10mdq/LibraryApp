using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public  class ControladorEditoriales
    {
       private RepositorioEditorialBDD ListaEditoriales = RepositorioEditorialBDD.GetInstance();

        public bool AgregarEditorial(string Nombre)
        {
            var result = false;
            Editoriales oEditorial = new Editoriales(Nombre);
            /*if(ListaEditoriales.BuscarEditorial(Nombre)==null)
            {
              
            }*/
           
            ListaEditoriales.AgregarEditorial(oEditorial);
            result = true;
            return result;

        }

       /* public void BorrarEditorial(Editoriales e)
        {
          //  ListaEditoriales.BorrarEditorial(e);
        }*/

        public List<Editoriales>DevolverEditoriales()
        {
            return ListaEditoriales.ListarEditoriales();
        }

        public Editoriales BuscarEditorial(string nombre)
        {
            return ListaEditoriales.BuscarEditorial(nombre);
        }
    }
}
