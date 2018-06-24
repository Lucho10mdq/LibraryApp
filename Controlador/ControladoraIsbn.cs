using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public  class ControladoraIsbn
    {
        private RepositorioIsbn ListaIsbn = RepositorioIsbn.GetInstance();

        public void AgregarIsbn(int ideditorial1,string titulo1,int idisbn1,int nroIsbn, int ideditorial2, string titulo2,int  idisbn2,int nroIsbn2,int ideditorial3,string titulo3,int idisbn3, int nroIsb3)
        {
            Isbn oIsn = new Isbn(ideditorial1,titulo1,idisbn1,nroIsbn);
           Isbn oIsn1 = new Isbn(ideditorial2,titulo2,idisbn2, nroIsbn2);
            Isbn oIsn2 = new Isbn(ideditorial3,titulo2,idisbn3,nroIsb3);

            ListaIsbn.AgregarIsbn(oIsn);
            ListaIsbn.AgregarIsbn(oIsn1);
            ListaIsbn.AgregarIsbn(oIsn2);
        }

        public List<Isbn> DevolverIsbn()
        {
            return ListaIsbn.DevolverTodosIsbn();
        }
    }
}
