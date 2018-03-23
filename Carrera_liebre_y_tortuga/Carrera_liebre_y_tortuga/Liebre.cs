using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_liebre_y_tortuga
{
    class Liebre:Competidor
    {
        public Liebre()
        {
            _nopasos = 0;
        }
        public override void avanzar()
        {
            int n = alea.Next(1,11);
            if (n < 3)
            {
                _nopasos += 0;
            }
            else
            {
                if (n < 5)
                {
                    _nopasos += 9;

                }
                else
                {
                    if (n < 6)
                    {
                        _nopasos -= 12;
                    }
                    else
                    {
                        if (n < 9)
                        {
                            _nopasos += 1;

                        }
                        else
                        {
                            _nopasos -= 2;
                            if (_nopasos < 0)
                            {
                                _nopasos = 0;
                            }
                        }
                    }
                }
            }
        }
        public override string ToString()
        {
            return "La liebre esta en " + this.noPasos;
        }
    }
}
