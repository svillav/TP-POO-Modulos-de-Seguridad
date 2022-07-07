using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{

    public class SingletonContexto
    {
        private static SingletonContexto _instance;
        private static ContextoContainer _context;

        private SingletonContexto() { }

        public static SingletonContexto get_instance()
        {
            if(_instance == null)
            {
                _instance = new SingletonContexto();
                _context = new ContextoContainer();
            }
            return _instance;
        }

        public ContextoContainer Contexto
        {
            get { return _context; }
        }
    }
}
