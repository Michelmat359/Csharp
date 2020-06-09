using System;

namespace MiClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();

            p.hablar();
            p.setNombre("Angel Arias");
            Console.WriteLine("El nombre " + p.getNombre() + "ha sido modificado.");

            Console.ReadKey();


        }
    }
}
