using System;
using System.Collections;
using System.Collections.Generic;

namespace EjemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agregar elementos lista
            IList<int> entero = new List<int>();
            entero.Add(2);
            entero.Add(3);

            IList<string> cadena = new List<string>();
            cadena.Add("segundo");
            cadena.Add("tercero");

            IList<int> entero1 = new List<int>() { 2, 3 };
            IList<string> cadena1 = new List<string>() {"segundo","tercero" };

            // metodo addRange
            List<int> entero3 = new List<int>();
            entero3.AddRange(entero);

            // Acceder a los elementos coleccion List
            Console.WriteLine("El valor en la posicion 1 de mi lista es: {0}", entero[0]);
            foreach (int i in entero) {
                Console.WriteLine(i);
            }

            for (int i = 0; i < entero.Count; i++) {
                Console.WriteLine(entero[i]);
            }

            // Insertar elementos a la coleccion generica List
            IList<int> entero4 = new List<int>() {2,3};
            entero4.Insert(1, 5);
            foreach (int i in entero4)
            {
                Console.WriteLine(i);
            }

            // Eliminar elementos de la coleccion generica List
            IList<int> entero5 = new List<int>() { 1, 2, 3, 4, 5 };
            entero5.Remove(2); // elimina el primer valor numero 2 que encuentre en la lista
            entero5.RemoveAt(2); // elimina el elemento que esta en la segunda posicion de la lista
            foreach (int i in entero5)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
