using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Ingrese el numero de operaciones que desea realizar: ");
            int NumeroOperaciones = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para empezar las operaciones: ");
            int NumeroInicial = int.Parse(Console.ReadLine());

            List<ICalcular> calculadora = new List<ICalcular>();

            Calculadora calculadoras = new Calculadora(NumeroInicial);

            calculadora.Add(new Cuadrado());
            calculadora.Add(new Cubo());
            calculadora.Add(new PerroFactorial());
            calculadora.Add(new PersonaQueSuma5());
            calculadora.Add(new RobotFibonacci());



            for (int i = 1; i <= NumeroOperaciones; i++)
            {
                int num = calculadora[rnd.Next(0, 5)].Calcular(calculadoras.GetNumero());
                calculadoras.Calcular(num);
                Console.WriteLine(calculadoras.GetNumero());

            }
            Console.ReadLine();

            //-------BONUS-----------------------------------------------

            Console.WriteLine("Presione 0 para elevar al cuadrado");
            Console.WriteLine("Presione 1 para elevar al cubo");
            Console.WriteLine("Presione 2 para su factorial");
            Console.WriteLine("Presione 3 para sumarle 5");
            Console.WriteLine("Presione 4 para su fibonacci");
            int seleccion = int.Parse(Console.ReadLine());

                
            int numero = calculadora[seleccion].Calcular(calculadoras.GetNumero());
            calculadoras.Calcular(numero);
            Console.WriteLine(calculadoras.GetNumero());
            Console.ReadLine();
            
        }
    }
}
