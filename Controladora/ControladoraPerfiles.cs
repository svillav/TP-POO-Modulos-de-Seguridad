using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraPerfiles
    {
        private static ControladoraPerfiles _instance;

        private ControladoraPerfiles() { }

        public static ControladoraPerfiles get_instance()
        {
            if (_instance == null)
            {
                _instance = new ControladoraPerfiles();
            }
            return _instance;
        }

        public List<Modelo.Perfil> profile_list()
        {
            return Modelo.SingletonContexto.get_instance().Contexto.Perfil.ToList();
        }

        public void Llenar_Lista_Perfiles(List<Modelo.Perfil> profiles)
        {
            Modelo.SingletonContexto.get_instance().Contexto.Perfil.AddRange(profiles);
            Modelo.SingletonContexto.get_instance().Contexto.SaveChanges();
        }
    }
}
