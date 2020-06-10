using System;
using espacionombre1;
using espacionombre1.espacionombre2;


namespace espacionombre1
{
    class clase1
    {
        public void funcion() 
        {
            Console.WriteLine("Estoy dentro del Espacio de Nombres 1");
        }
    }

    namespace espacionombre2
    {
        class clase2
        {
            public void funcion()
            {
                Console.WriteLine("Estoy dentro del Espacio de Nombres 2");
            }
        }
    }

}

namespace EspacioNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            espacionombre1.clase en1 = new espacionombre1.clase();
            espacionombre2.clase en2 = new espacionombre2.clase();
            */

            clase1 en1 = new clase1();
            clase2 en2 = new clase2();
            en1.funcion();
            en2.funcion();
            

            Console.ReadKey();
        }
    }
}
