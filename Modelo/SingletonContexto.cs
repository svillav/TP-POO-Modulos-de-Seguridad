using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SingletonContext
    {
        private static SingletonContext _instance;
        private static ContextoContainer _context;

        private SingletonContext() { }

        public static SingletonContext getInstance()
        {
            if( _instance == null )
            {
                _instance = new SingletonContext();
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
