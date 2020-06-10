using System;

namespace EStructuras
{
    class Program
    {
        //Definicion de estructuras 1
        /*
        struct Libros 
        {
            public string titulo;
            public string autor;
            public string categoria;
            public int id_libro;
        }
        */

        struct Libros {
            public string titulo;
            public string autor;
            public string categoria;
            public int id_libro;

            public void getValores(string t, string a, string c, int id) {
                titulo = t;
                autor = a;
                categoria = c;
                id_libro = id;
            }

            public void mostrar() 
            {
                Console.WriteLine("El titulo es {0}", titulo);
                Console.WriteLine("El autor es {0}", autor);
                Console.WriteLine("La categoria es {0}", categoria);
                Console.WriteLine("El ID es {0}\n", id_libro);

            }



        }

        static void Main(string[] args)
        {
            /*
            Libros libro1;
            Libros libro2;

            libro1.titulo = "La computacion en la nube";
            libro1.autor = "Miguel Angel Mateo";
            libro1.categoria = "Informatica";
            libro1.id_libro = 123;

            libro2.titulo = "Programando en C#";
            libro2.autor = "Miguel Angel Mateo";
            libro2.categoria = "Informatica";
            libro2.id_libro = 321;

            Console.WriteLine("Esto son los datos del Libro 1;");
            Console.WriteLine("El titulo es {0}", libro1.titulo);
            Console.WriteLine("El autor es {0}", libro1.autor);
            Console.WriteLine("La categoria es {0}", libro1.categoria);
            Console.WriteLine("El ID es {0}\n", libro1.id_libro);

            Console.WriteLine("Esto son los datos del Libro 1;");
            Console.WriteLine("El titulo es {0}", libro2.titulo);
            Console.WriteLine("El autor es {0}", libro2.autor);
            Console.WriteLine("La categoria es {0}", libro2.categoria);
            Console.WriteLine("El ID es {0}\n", libro2.id_libro);
            */

            Libros libro1 = new Libros();
            Libros libro2 = new Libros();

            libro1.getValores("La compotuacion en la nube", "Miguel Angel Mateo", "Informatica", 123);

            libro2.getValores("Programando con C#", "Miguel Angel Mateo", "Informatica", 321);

            libro1.mostrar();
            libro2.mostrar();

            Console.ReadKey();
        }
    }
}
