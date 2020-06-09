using System;

namespace BucleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bucles Repeticion:");
            Console.WriteLine("For:");

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }
            Console.WriteLine("Foreach:");
            string[] nombres = { "angel", "Patricia", "Luis", "Marta" };
            foreach (string nombre in nombres) {
                Console.WriteLine(nombre);
            }

            Console.ReadKey();
        }
    }
}
