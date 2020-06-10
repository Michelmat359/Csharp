using System;
using System.Security.Cryptography.X509Certificates;

delegate void numeros(int n);

namespace metodosAnonimos
{
    class Program
    {
        static int numero = 10;
        public static void sumarnumeros(int n)
        {
            numero += n;
            Console.WriteLine("Este metodo tiene el valor: {0}", numero);
        }

        public static void multiplicarNumeros(int n) {
            numero *= n;
            Console.WriteLine("Este metodo tiene el valor: {0}", numero);
        }

        public static int obtenerNumero() {
            return numero;

        }

        static void Main(string[] args)
        {

            numeros num = delegate (int x)
            {
                Console.WriteLine("El valor de este metodo es: {0}", x);
            };

            num(10);

            num = new numeros(sumarnumeros);
            num(5);
            num = new numeros(multiplicarNumeros);
            num(10);
            
            Console.ReadKey();
        }
    }
}
