using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Calculadora
    {
        private int Numero;
        public List<ICalcular> Calculadoras;

        public Calculadora(int ValorInicial)
        {
            Numero = ValorInicial;

        }
        public void Calcular(int Num)
        {
            Numero = Num;
        }

        public int GetNumero()
        {
            return Numero;
        }
    }
}
