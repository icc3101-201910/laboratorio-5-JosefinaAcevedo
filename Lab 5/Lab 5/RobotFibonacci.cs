using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class RobotFibonacci : ICalcular
    {
        public int Calcular(int Numero)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < Numero; i++)
            {
                int aux = a;
                a = b;
                b = aux + a;
            }
            return a;
        }
    }
}
