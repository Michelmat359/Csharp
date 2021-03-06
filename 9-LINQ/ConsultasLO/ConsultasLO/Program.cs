﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultasLO
{
    class Program
    {
        class Colegio {
            public int id { get; set; }
            public string nombre { get; set; }
        }
        static void Main(string[] args)
        {
            // Ejemplo de un array
            /*string[] nombres = { "Miguel angel", "Javier", "Laura", "Alberto" };

            var lista = from n in nombres select n;

            foreach (var l in lista) {
                Console.WriteLine(l);

            }
            */

            // Ejemplo con una clase

            List<Colegio> colegios = new List<Colegio>();

            colegios.Add(new Colegio { id = 1, nombre = "Colegio 1"});
            colegios.Add(new Colegio { id = 2, nombre = "Colegio 2"});
            colegios.Add(new Colegio { id = 3, nombre = "Colegio 3"});

            var colegioLista = from c in colegios select c;

            foreach (var colegio in colegioLista) {
                Console.WriteLine("El colegio con el id {0} se llama {1}", colegio.id, colegio.nombre);

            }

            Console.ReadKey();

        }
    }
}
