using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Coladera
    {
        private int[] numeros = new int[1000];

        public string eratostenes()
        {
            string linea = "";

            for (int x = 1; x < 1000; x++) numeros[x] = 1; 

            for (int x = 2; x < 1000; x++)
            {
                int div = 1;                    
                for (int y = 2; y <= x; y++)   
                {
                    if ((x % y) == 0) div++;   
                }                              
                if (div == 2) for (int z = x + x; z < 1000; z += x) numeros[z] = 0;   
            }                                                                           


            for (int x = 2; x < 1000; x++)
            {
                if (numeros[x] == 1) linea += x + " , ";
            }

            return linea;
        }
    }
}
