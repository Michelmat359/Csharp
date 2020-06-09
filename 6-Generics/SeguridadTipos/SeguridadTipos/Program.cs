using System;
using System.Collections;
using System.Collections.Generic;

namespace SeguridadTipos
{
    class Program
    {

        public class usuario { 
        
            int id { get; set; }
            string nombre { get; set; }
        }
        static void Main(string[] args)
        {
            /*  //Coleccion NO GENERICA arraylist
               ArrayList objetos = new ArrayList();
               objetos.Add(1);
               objetos.Add("Miguel angel");
               objetos.Add(new usuario());

               foreach ( int i in objetos){
                   Console.WriteLine(i);
               }
            */

            List<int> objetos = new List<int>();
            objetos.Add(1);
            objetos.Add(2);
            // objetos.Add("cadena") <-- El IDE detecta el error con la List que es generico. 
            objetos.Add(3);

            foreach (int i in objetos)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
