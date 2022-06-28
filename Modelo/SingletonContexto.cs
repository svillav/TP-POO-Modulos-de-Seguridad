using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
<<<<<<< HEAD
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
=======
    public class SingletonContexto
    {
        private static SingletonContexto _instancia;
        private static ContextoContainer _contexto;

        private SingletonContexto() { }

        public static SingletonContexto obtener_instancia()
        {
            if(_instancia == null)
            {
                _instancia = new SingletonContexto();
                _contexto = new ContextoContainer();
            }
            return _instancia;
>>>>>>> development
        }

        public ContextoContainer Contexto
        {
<<<<<<< HEAD
            get { return _context; }
=======
            get { return _contexto; }
>>>>>>> development
        }
    }
}
