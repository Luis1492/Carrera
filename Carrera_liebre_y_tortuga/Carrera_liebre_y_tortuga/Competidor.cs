using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_liebre_y_tortuga
{
    abstract class Competidor
    {
        protected int _nopasos;
        protected static Random alea = new Random();
        public int noPasos
        {
            get { return _nopasos; }
        }
        public virtual void avanzar() { }
        
    }
}
