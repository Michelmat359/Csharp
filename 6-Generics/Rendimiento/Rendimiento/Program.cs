using System;
using System.Collections;

namespace Rendimiento
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objetos = new ArrayList();

            objetos.Add(50); //boxing

            int x = (int)objetos[0]; //unboxing

            foreach (int i in objetos) {
                Console.WriteLine(i);

            }

            Console.ReadKey();
        }
    }
}
