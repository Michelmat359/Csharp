using System;
using System.Runtime.CompilerServices;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings:");
            // metodo substring
            string nombre = "Alexandre Gonzalez";
            string apellidos = nombre.Substring(10, 8);
            Console.WriteLine(apellidos);
            //Console.ReadKey();

            // metodo IndexOf
            string nombre1 = "Alexandre Gonzalez - programando en C#";
            int posicion1 = nombre1.IndexOf("programando");
            Console.WriteLine(posicion1);
            int posicion2 = nombre1.IndexOf("Gonzalez", 5);
            Console.WriteLine(posicion2);
            //Console.ReadKey();

            // metodos ToUpper y ToLower

            string nombre2 = "Juan Garcia Robles";
            string minusculas = nombre2.ToLower();
            string mayusculas = nombre2.ToUpper();

            Console.WriteLine(minusculas);
            Console.WriteLine(mayusculas);
            //Console.ReadKey();

            // metodos StartsWith y EndWith

            string archivo = "comctl32.dll";
            if (archivo.StartsWith("com")) {
                Console.WriteLine("El archivo empieza con COM");
            }
            if (archivo.EndsWith("dll")) {
                Console.WriteLine("El archivo acaba con DLL");
            }

            //Console.ReadKey();

            // funciones TrimStart, TrimEnd y Trim

            string nombre3 = " Rodriguez ";
            // Quita espacios delante;
            string ejemplo1 = nombre3.TrimStart();
            //Quita espacios detrás;
            string ejemplo2 = nombre3.TrimEnd();
            //Quita espacios delante y detrás;
            string ejemplo3 = nombre3.Trim();

            Console.WriteLine(ejemplo1);
            Console.WriteLine(ejemplo2);
            Console.WriteLine(ejemplo3);
            //Console.ReadKey();

            // funciones PAdLefft y PadRigth

            string nombre4 = "Gonzalez";
            string codigo = "123";
            nombre4 = nombre4.PadRight(10, 'X');
            codigo = codigo.PadLeft(6, '0');

            Console.WriteLine(nombre4 + ' ' +codigo);
            //Console.ReadKey();

            // Funciones Join y Split

            string linea = "Prueba, 10, 20, 10/09/2018";
            Console.WriteLine(linea);
            string[] campos = linea.Split(new char[] {',' });
            Console.WriteLine(campos[0]);
            Console.WriteLine(campos[1]);
            Console.WriteLine(campos[2]);
            Console.WriteLine(campos[3]);

            string lineaNueva = String.Join(";", campos);
            Console.WriteLine(lineaNueva);

            //funcion format

            string formato = String.Format("Aqui voy a poner el {0}. Hoy estamos a {1}. Este es un valor numerico {2}", "parametro", DateTime.Now, 15);
            Console.WriteLine(formato);


            // Metodo replace

            string texto1 = "Curso de Desarrollo en C# - Curso de ASP.NET MVC de Ángel Arias";
            Console.WriteLine(texto1);
            string nuevotexto1 = texto1.Replace(" Curso ", " Video Curso ");
            Console.WriteLine(nuevotexto1);

            // Metodo Length

            string texto2 = "Angel Arias. Cursos de desarrollo informatico";
            Console.WriteLine(texto2);
            int numerotexto2 = texto2.Length;
            Console.WriteLine(numerotexto2);


            Console.ReadKey();

        }
    }
}
