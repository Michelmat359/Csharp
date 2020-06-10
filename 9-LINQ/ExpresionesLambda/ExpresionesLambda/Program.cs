using System;
using System.Linq;

namespace ExpresionesLambda
{
    class Program
    {
       // delegate int delegado(int i);

        static void Main(string[] args)
        {
            /* delegado miDelegado = y => y * y;
             int j = miDelegado(5);
             Console.WriteLine(j);
            */
            /*
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 25, 27, 29, 50 };
            double valorMedio = numeros.Where(numeros => numeros % 2 == 1).Average();
            Console.WriteLine(valorMedio);
            */

            // Arboles de expresion
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numeros.Where(x =>
            {
                if (x <= 3) return true;
                else if (x >= 7) return true;
                return false;
            }))
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
