using System;

namespace breackWihile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program While");
            int i = 1;
            while (i < 10) {
                if (i == 5) {
                    Console.WriteLine("Nos vamos");
                    break;
                }
                Console.WriteLine(i);
                i++;
            }






            Console.ReadKey();
        }
    }
}
