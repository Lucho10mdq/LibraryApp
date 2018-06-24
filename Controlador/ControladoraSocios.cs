using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class ControladoraSocios
    {
       private RepositorioSociosBDD ListaSocios = RepositorioSociosBDD.GetInstance();
        
        public bool Agregar(string nombre,string apellido,string domicilio,string telefono,string dni)
        {
            var result = false;
            Socios oSocios = new Socios(dni, domicilio, telefono, apellido, nombre);
            /* if(ListaSocios.BuscarSocioPorDni(dni)==null)
             {
                 ListaSocios.AgregarSocios(oSocios);
                 result = true;
             }*/
            ListaSocios.Agregar(oSocios);
            result = true;
            return result;
            
        }

      /*  public void Borrar(Socios s)
        {
            ListaSocios.BorrarSocio(s);
        }*/

        public Socios BuscarPorDni(string apellido)
        {
            return ListaSocios.BuscarSocoioPorApellido(apellido);
        }

      public int EliminarSocio(string dni)
        {
            var result = 0; 
             result = ListaSocios.EliminarSocioPorDni(dni);

            return result;            
        }
        
        public List<Socios> DevolverSocios()
        {
           return ListaSocios.DeVolverTodosLosSocios();
        }

       

    }
}
