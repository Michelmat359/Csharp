using System;

namespace MiConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.nombre = "Miguel Angel";
            p.ojos = 2;
            p.piernas = 2;
            p.brazos = 2;
            p.color_ojos = "Castaño";
            p.color_pelo = "Moreno";

            Console.WriteLine("Mi nombre es " + p.nombre + " mi color de pelo es " + p.color_pelo + " y mi color de ojos es " + p.color_ojos + "\ny tengo " + p.ojos + " ojos, " + p.brazos + " brazos y " + p.piernas + " piernas.");
            Console.ReadKey();
        }
    }
}
