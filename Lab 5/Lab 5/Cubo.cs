﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Cubo : ICalcular
    {
        public int Calcular(int Numero)
        {
            return (int)(Math.Pow(Numero, 3) + 0.5);
        }
    }
}
