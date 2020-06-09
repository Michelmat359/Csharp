using System;


delegate int numeros(int n);

namespace Delegados
{
    class Program
    {
        static int num = 10;

        public static int sumarNumeros(int p) {
            num += p;
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
