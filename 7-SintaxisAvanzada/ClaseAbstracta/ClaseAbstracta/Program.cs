using System;

namespace ClaseAbstracta
{
    public abstract class Hablar 
    {
        public abstract void charlar();

        public virtual void adios() {
            Console.WriteLine("La clase hablar nos esta diciendo adios.");
        }

    
    }

    public class Conversacion : Hablar {

        public override void charlar()
        {
            Console.WriteLine("Hola, estoy charlando");
        }

        public override void adios()
        {
            Console.WriteLine("La clase conversacion nos esta diciendo adios. ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Conversacion conver = new Conversacion();
            conver.charlar();
            conver.adios();
            Console.ReadKey();
        }
    }
}
