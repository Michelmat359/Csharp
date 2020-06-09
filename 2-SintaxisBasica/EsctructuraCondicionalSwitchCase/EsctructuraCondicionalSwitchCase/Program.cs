using System;

namespace EsctructuraCondicionalSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            string mes;
            Console.WriteLine("Introduce el nombre de un mes");
            mes = Console.ReadLine();

            switch (mes) {

                case "enero":
                case "marzo":
                case "julio":
                case "agosto":
                case "diciembre":
                    Console.WriteLine("Este mes tiene 31 días");
                    break;
                case "febrero":
                    Console.WriteLine("Este mes tiene 28 días");
                    break;
                default:
                    Console.WriteLine("Este mes tiene 30 días");
                    break;
            }




            Console.ReadKey();
        }
    }
}
