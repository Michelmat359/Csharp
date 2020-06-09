using System;

namespace ContinueWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros Impares!");
            int i = 0;
            while (i < 10) {
                i++;
                if (i % 2 == 0)
                {
                    continue;
                }
                else {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }
    }
}
