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
       private RepositorioEditoriales ListaEditoriales = RepositorioEditoriales.GetInstance();

        public bool AgregarEditorial(int IdEditorial,string Nombre )
        {
            var result = false;
            Editoriales oEditorial = new Editoriales(IdEditorial, Nombre);
            if(ListaEditoriales.BuscarEditorial(Nombre)==null)
            {
                ListaEditoriales.AgregarEditorial(oEditorial);
                result = true;
            }
            return result;
          

        }

        public void BorrarEditorial(Editoriales e)
        {
            ListaEditoriales.BorrarEditorial(e);
        }

        public List<Editoriales>DevolverEditoriales()
        {
            return ListaEditoriales.DevolverEditoriales();
        }

        public Editoriales BuscarEditorial(string nombre)
        {
            return ListaEditoriales.BuscarEditorial(nombre);
        }
    }
}
