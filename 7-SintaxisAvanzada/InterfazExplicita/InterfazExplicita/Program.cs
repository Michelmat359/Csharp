using System;

namespace InterfazExplicita
{
    class Program
    {

        public interface IOrganismo {
            void respirar();
            void mover();
        }

        public interface IAnimal {
            void mover();
            void viviparo();
        }

        class Perro : IOrganismo, IAnimal {
            public void respirar() {
                Console.WriteLine("Este organismo respira");
            }

            void IOrganismo.mover() {
                Console.WriteLine("Este organismo se mueve");
            }

            void IAnimal.mover() {
                Console.WriteLine("Este organismo se mueve");

            }
            public void viviparo() {
                Console.WriteLine("Este organismo es viviparo");

            }

        }

        static void Main(string[] args)
        {
            Perro perros = new Perro();
            IOrganismo organismo = perros;
            IAnimal animal = perros;

            perros.respirar();
            perros.viviparo();

            organismo.mover();
            animal.mover();

            Console.ReadKey();
        }
    }
}
