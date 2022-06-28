using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraPerfiles
    {
        private static ControladoraPerfiles _instancia;

        private ControladoraPerfiles() { }

        public static ControladoraPerfiles obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraPerfiles();
            }
            return _instancia;
        }

        public List<Modelo.Perfil> Listar_Perfiles()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.Perfil.ToList();
        }

        public void Llenar_Lista_Perfiles(List<Modelo.Perfil> perfiles)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.Perfil.AddRange(perfiles);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
    }
}
