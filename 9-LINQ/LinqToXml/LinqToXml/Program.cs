﻿using System;
using System.Xml.Linq;
using System.Linq;


namespace LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {

            string docXML = @"<Departamentos>
                                <Departamento>Administracion</Departamento>
                                <Departamento>Ventas</Departamento>
                                <Departamento>Atencion al Cliente</Departamento>
                                <Departamento>Marketing</Departamento>
                              </Departamentos>";

            XDocument documento = new XDocument();
            documento = XDocument.Parse(docXML);

            // añadir elementos al documento XML

            documento.Element("Departamentos").Add(new XElement("Departamento", "Formacion"));

            documento.Element("Departamentos").AddFirst(new XElement("Departamento", "Finanzas"));

            // eliminar elementos del documento XML

            documento.Descendants().Where(e => e.Value == "Ventas").Remove();

            var resultado = documento.Element("Departamentos").Descendants();

            foreach (XElement elementos in resultado) {
                Console.WriteLine("El nombre del departamento es {0}", elementos.Value);
            }
            


            Console.ReadKey();
        }
    }
}
