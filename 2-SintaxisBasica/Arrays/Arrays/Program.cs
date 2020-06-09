using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays:");
            string[] pilotos = new string[4] { "Alonso", "Hamilton", "Verstappen", "Sainz" };
            Console.WriteLine(pilotos[2]);
            Console.WriteLine();
            pilotos[2] = "Vettel";
            foreach (string piloto in pilotos) {
                Console.WriteLine(piloto);
            }
            Console.ReadKey();
        }
    }
}
