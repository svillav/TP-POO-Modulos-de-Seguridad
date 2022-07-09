using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraPerfiles
    {
        //private static ControladoraPerfiles _instancia;

        public ControladoraPerfiles() { }

        /*public static ControladoraPerfiles obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraPerfiles();
            }
            return _instancia;
        }*/
        public static List<Modelo.Profile> GetPerfiles()
        {
            return Modelo.DTO.PerfilesDto.GetPerfiles();
        }

        /*public List<Modelo.Perfil> Listar_Perfiles()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.Perfil.ToList();
        }*/

        
    }
}
