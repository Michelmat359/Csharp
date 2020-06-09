using System;

namespace LanzarExcepciones3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para debbugin usar F11
            int num1, num2, resultado;

            Console.WriteLine("Introducir el primer numero:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introducir el segundo numero:");
            num2 = Convert.ToInt32(Console.ReadLine());

            try 
            {
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la operacion es {0}", resultado);

            }
            catch (Exception e){
                Console.WriteLine("Error: {0}", e.ToString());
            }

            Console.ReadKey();

        }
    }
}
