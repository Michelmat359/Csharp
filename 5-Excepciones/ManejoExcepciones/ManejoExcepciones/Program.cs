using System;

namespace ManejoExcepciones
{
    class DivNumeros
    {

        int resultado;

        DivNumeros() {
            resultado = 0;
        }

        public void Division(int num1, int num2)
        {
            try
            {
                resultado = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Se ha producido una excepcion del tipo: {0}", e);
            }
            finally
            {
                Console.WriteLine("El resultado es: {0}", resultado);
            }
        }

        static void Main(string[] args)
        {
            DivNumeros d = new DivNumeros();
            d.Division(23, 0);
            Console.ReadKey();
        }
    }
}
