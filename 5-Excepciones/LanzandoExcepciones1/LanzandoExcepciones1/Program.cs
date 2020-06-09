using System;

namespace LanzandoExcepciones1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;
            Console.WriteLine("Por favor introduce el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor introduce el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                resultado = num1 / num2;
                Console.WriteLine("{0}", "{1}", "{2}", num1, num2, resultado);
            }
            catch {
                Console.WriteLine("Se ha producido una excepcion");
                throw;
            }
            Console.ReadKey();
        }
    }
}
