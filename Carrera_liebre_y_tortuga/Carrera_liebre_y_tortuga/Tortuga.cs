using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_liebre_y_tortuga
{
    class Tortuga : Competidor
    {
        public Tortuga()
        {
            _nopasos = 0;
        }
        public override void avanzar()
        {
            int n = alea.Next(1, 11);
            if (n < 6)
            {
                _nopasos += 3;

            }
            else
            {
                if (n < 8)
                {
                    _nopasos -= 6;
                }
                else
                {
                    _nopasos += 1;
                }
                if (_nopasos < 0)
                {
                    _nopasos = 0;
                }
            }
        }
        public override string ToString()
        {
            return "La tortuga esta en " + this.noPasos;
        }
    }
}
