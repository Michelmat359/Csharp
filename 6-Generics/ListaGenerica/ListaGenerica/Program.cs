using System;
using System.Collections.Generic;

namespace ListaGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entero = new List<int>();
            entero.Add(1);
            entero.Add(2);
            entero.Add(3);

            for (int i=0; i < entero.Count; i++) {
                Console.WriteLine("El valor de la lista es {0}", entero[i]);
            
            }

     

            List<string> cadena = new List<string>();
            cadena.Add("primero");
            cadena.Add("segundo");
            cadena.Add("tercero");

            for (int i = 0; i < entero.Count; i++)
            {
                Console.WriteLine("El valor de la lista es {0}", cadena[i]);

            }

            Console.ReadKey();

        }
    }
}
