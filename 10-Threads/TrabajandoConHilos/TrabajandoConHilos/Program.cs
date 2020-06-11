using System;
using System.Threading;

namespace TrabajandoConHilos
{
    class Program
    {
        public static void LlamarHiloHijo() {
            //Console.WriteLine("El hilo hijo se está ejecutando");

            /*Console.WriteLine("Comienza la ejecucion del Hilo Hijo");

            int parar = 5000;
            Console.WriteLine("El hilo hijo se parar durante {0} segundos", parar / 1000);
            Thread.Sleep(parar);
            Console.WriteLine("El Hilo hijo continua su ejecucion");*/

            try
            {
                Console.WriteLine("Comienza la ejecucion del Hilo Hijo");

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(i);
                }
                Console.WriteLine("El Hilo hijo se ha completado");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            finally {
                Console.WriteLine("No se ha producido ningun eror");
            }

        }
        static void Main(string[] args)
        {
            
            
            ThreadStart refHijo = new ThreadStart(LlamarHiloHijo);
            Console.WriteLine("El Hilo principal --> Esta creando el hilo Hijo");

            Thread HiloHijo = new Thread(refHijo);
            HiloHijo.Start();

            Thread.Sleep(2000);
            Console.WriteLine("El Hilo hijo será destruido");
            HiloHijo.Abort();

            Console.ReadKey();

        }
    }
}
