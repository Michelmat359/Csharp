using System;
using System.Collections.Generic;
using System.Text;

namespace MiClase
{
    class Persona
    {
        string nombre;
        int ojos, brazos, piernas;
        string color_ojos;
        string color_pelo;

        public void andar(int velocidad) {
            Console.WriteLine("La persona anda a: " + velocidad + " por hora.");
        }

        public void hablar() {
            Console.WriteLine("La perosona está hablando.");
        }

        public string getNombre() {
            return nombre;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }
    }
}
