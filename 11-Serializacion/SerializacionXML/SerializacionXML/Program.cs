using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SerializacionXML
{
    public class Persona
    {
        [XmlElement(Order = 2)]
        public string nombre;
        [XmlElement(Order = 1)]
        //      [XmlAttribute("MayorEdad")]
        public int edad;
        [XmlIgnore]
        public string email;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.nombre = "Miguel Angel";
            p.edad = 30;
            p.email = "email@email.com";

            XmlSerializer xs = new XmlSerializer(typeof(Persona));

            using (Stream s = File.Create(@"C:\temp\persona.xml"))
            {
                xs.Serialize(s, p);
            }

            Persona p2 = new Persona();

            using (Stream s = File.OpenRead(@"C:\temp\persona.xml"))
            {
                p2 = (Persona)xs.Deserialize(s);
            }

            Console.WriteLine("El nombre es {0} y tiene {1} años", p2.nombre, p2.edad);
            Console.ReadKey();
        }
    }
}
