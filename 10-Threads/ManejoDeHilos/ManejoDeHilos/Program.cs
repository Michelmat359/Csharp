using System;
using System.Threading;



namespace ManejoDeHilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread hilo = Thread.CurrentThread;

            hilo.Name = "Hilo principal de la aplicacion";
            Console.WriteLine("El hilo principal se llama : {0}", hilo.Name);
            Console.ReadKey();
        }
    }
}
