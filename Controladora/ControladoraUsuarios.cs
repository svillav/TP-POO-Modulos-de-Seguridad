using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controladora
{
    public class ControladoraUsuarios
    {
        private static ControladoraUsuarios _instance;

        private ControladoraUsuarios() { }

        public static ControladoraUsuarios get_instance()
        {
            if(_instance == null)
            {
                _instance = new ControladoraUsuarios();
            }
            return _instance;
        }

        public List<Modelo.Usuario> list_users()
        {
            return Modelo.SingletonContexto.get_instance().Contexto.Usuario.ToList();
        }

        public void add_user(Modelo.Usuario user)
        {
            Modelo.SingletonContexto.get_instance().Contexto.Usuario.Add(user);
            Modelo.SingletonContexto.get_instance().Contexto.SaveChanges();
        }

        public Modelo.Usuario Obtener_Usuario(int CODE)
        {
            return Modelo.SingletonContexto.get_instance().Contexto.Usuario.Find(CODE);
        }

        public void Eliminar_Usuario(Modelo.Usuario user)
        {
            Modelo.SingletonContexto.get_instance().Contexto.Usuario.Remove(user);
            Modelo.SingletonContexto.get_instance().Contexto.SaveChanges();
        }

    }
}
