using System;
using System.Collections;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[2] { "Miguel Angel", "http://facebook.com" };
            //Bucle FOR
            for (IEnumerator e = nombres.GetEnumerator(); e.MoveNext(); Console.WriteLine(e.Current)) ;


            // Bucle FOREACH
            foreach (string nombre in nombres) {
                Console.WriteLine(nombre);
            }
            Console.ReadKey();
        }
    }
}
