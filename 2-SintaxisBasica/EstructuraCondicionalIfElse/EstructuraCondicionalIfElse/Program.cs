using System;

namespace EstructuraCondicionalIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("¿Que nota ha sacao el Alumno?");
            double media = Convert.ToDouble(Console.ReadLine());
            /*Estrutura normal */
            /*if (media > 7)
            {
                Console.WriteLine("El alumno a Aprobado el examen");
            }
            else if (media < 7 && media > 5) {
                Console.WriteLine("El Alumno tiene que ir a la recuperacion");
            }
            else
            {
                Console.WriteLine("El alumno ha suspendido el Examen");
            }*/

            string resultado = "El alumno ha ";

            resultado += media >= 7 ? "aprobado" : "suspendido";
            Console.WriteLine(resultado);

            /*Estrutura ternario */
            Console.ReadLine();
        }
    }
}
