using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Calculadora calculo = new Calculadora();

            double result = calculo.Suma(num1, num2);

            Console.WriteLine(result);
        }

    }
}


