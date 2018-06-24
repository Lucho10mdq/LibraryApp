using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class RepositorioEditoriales : Singleton<RepositorioEditoriales>
    {
        private List<Editoriales> ListaEditoriales = new List<Editoriales>();
        static RepositorioEditoriales instance = null;

        public void AgregarEditorial(Editoriales e)
        {
            ListaEditoriales.Add(e);
        }
        public void BorrarEditorial(Editoriales e)
        {
            ListaEditoriales.Remove(e);
        }
        public List<Editoriales> DevolverEditoriales()
        {
            return ListaEditoriales;
        }
        public Editoriales BuscarEditorial(string nombre)
        {
            Editoriales aux = null;

            foreach (Editoriales e in ListaEditoriales)
            {
                if (e.Nombre == nombre)
                {
                    return e;
                }
            }
            return aux;
        }
 
    }
}
