using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class RepositorioSocios : Singleton<RepositorioSocios>
    {
        private List<Socios> ListaSocios = new List<Socios>();
       // static RepositorioSocios instance = null;

        public void AgregarSocios(Socios oSoc)
        {
            ListaSocios.Add(oSoc);

        }
        public void BorrarSocio(Socios oSoc)
        {
            ListaSocios.Remove(oSoc);
        }

        public List<Socios> DevolverTodosLosSocios()
        {
            return ListaSocios;
        }
        public Socios BuscarSocioPorDni(string dni)
        {
            Socios aux = null;
            foreach (Socios s in ListaSocios)
            {
                if (s.Dni == dni)
                {
                    return s;
                }
            }
            return aux;
        }

        public Socios BuscarSocioPorApellido(string apellido)
        {
            Socios aux = null;
            foreach (Socios s in ListaSocios)
            {
                if (s.Apellido == apellido)
                {
                    return s;
                }
            }
            return aux;
        }
    }
}
