using System;
using System.Collections.Generic;

namespace GenericPersonalizado
{
    class Program
    {
        public class ListaElementos<T> {
            private List<T> elementos;

            public ListaElementos() {
                elementos = new List<T>();
            }

            public void Agregar(T nuevoelemento) {
                elementos.Add(nuevoelemento);
            }

            public void Eliminar(T elementoeliminar) {
                elementos.Remove(elementoeliminar);
            }

            public void Listar() {
                foreach (var elemento in elementos) {
                    Console.WriteLine("El elemento es: {0}", elemento);
                }
            }

        }
        static void Main(string[] args)
        {
            ListaElementos<int> ListaEntero = new ListaElementos<int>();
            ListaEntero.Agregar(1);
            ListaEntero.Agregar(2);
            ListaEntero.Agregar(3);
            ListaEntero.Eliminar(2);
            ListaEntero.Listar();
            Console.ReadKey();

            ListaElementos<string> ListaCadena = new ListaElementos<string>();
            ListaCadena.Agregar("Miguel");
            ListaCadena.Agregar("Paco");
            ListaCadena.Agregar("Angel");
            ListaCadena.Eliminar("Paco");
            ListaCadena.Listar();
            Console.ReadKey();

        }
    }
}
