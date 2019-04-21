using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class PerroFactorial : ICalcular
    {
        public int Calcular(int Numero)
        {
            int Factorial = 1;

            for (int i = 1; i <= Numero; i++)
            {
                Factorial = Factorial * i;
            }
            return Factorial;
        }
    }
}
