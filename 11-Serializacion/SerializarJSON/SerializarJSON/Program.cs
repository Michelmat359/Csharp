using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SerializarJSON
{
    class Program
    {

        class Cliente { 
        
            [DataMember]
        public string nombre { get; set; }
            [DataMember]
        public string email { get; set; }
        }
        static void Main(string[] args)
        {
            Cliente objCliente = new Cliente()
            {
                nombre = "Miguel Angel",
                email = "email@email.com"
            };

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Cliente));

            MemoryStream objMs = new MemoryStream();
            js.WriteObject(objMs, objCliente);
            objMs.Position = 0;

            StreamReader sr = new StreamReader(objMs);

            string json = sr.ReadToEnd();
            objMs.Close();

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json))) {

                DataContractJsonSerializer deserializar = new DataContractJsonSerializer(typeof(Cliente));

                Cliente objCliente2 = (Cliente)deserializar.ReadObject(ms);

                Console.WriteLine(objCliente2.nombre);
                Console.WriteLine(objCliente2.email);
                Console.ReadKey();
            }

              
        }
    }
}
