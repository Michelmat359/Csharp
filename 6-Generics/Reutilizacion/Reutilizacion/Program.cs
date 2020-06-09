using System;
using System.Collections.Generic;

namespace Reutilizacion
{
    public class usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }

    }

    public class listaElementos<T>
    {
        private List<T> elementos;

        public listaElementos() {
            elementos = new List<T>();
        }

        public void Agregar(T nuevoelemento) {
            elementos.Add(nuevoelemento);
        }

        public void Eliminar(T eliminarelemento) {
            elementos.Remove(eliminarelemento);
        }
        static void Main(string[] args)
        {
            listaElementos<int> Entero = new listaElementos<int>();
            Entero.Agregar(1);
            Entero.Eliminar(1);

            listaElementos<string> cadena = new listaElementos<string>();
            cadena.Agregar("Miguel");
            cadena.Eliminar("Miguel");

            listaElementos<usuario> user = new listaElementos<usuario>();
            user.Agregar(new usuario { id = 1, nombre ="Miguel Angel"});
            user.Eliminar(new usuario { id = 1, nombre = "Miguel Angel" });

            Console.ReadKey();

        }
    }
}
