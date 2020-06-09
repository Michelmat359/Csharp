using System;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ver Funcion de escapes
            Console.WriteLine("Hello\tWorld \n Hola Mundo");
            Console.ReadKey();
            */

            const double pi = 3.14159;
            double radio;

            Console.WriteLine("Introducir el valor del radio:");
            radio = Convert.ToDouble(Console.ReadLine());

            double areaCirculo = pi * radio * radio;

            Console.WriteLine("El radio es: {0}, el Area del circulo es: {1}", radio, areaCirculo);
            Console.ReadKey();

        }
    }
}
