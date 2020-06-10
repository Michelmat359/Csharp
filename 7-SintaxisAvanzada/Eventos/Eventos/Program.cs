using System;

namespace Eventos
{

    class AgregarNumero {

        public delegate void delegado_Impar();
        public event delegado_Impar evento_Impar;

        public void Agregar() 
        {
            int resultado = 5 + 4;
            Console.WriteLine(resultado.ToString());

            if (resultado % 2 != 0) 
            {
                evento_Impar();
            
            }
        }
    }


    class Program
    {
        static void EventoMensaje() {
            Console.WriteLine("Se ha ejecutado el evento. Este evento es impar");        
        }

        static void Main(string[] args)
        {
            AgregarNumero a = new Eventos.AgregarNumero();
            a.evento_Impar += new AgregarNumero.delegado_Impar(EventoMensaje);
            a.Agregar();
            Console.ReadKey();

        }
    }
}
