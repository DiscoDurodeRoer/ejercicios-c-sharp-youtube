using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML2
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument();

            XmlElement concesionario = doc.CreateElement("concesionario");
            doc.AppendChild(concesionario);

            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            doc.InsertBefore(declaration, concesionario);

            XmlElement coches = doc.CreateElement("coches");
            concesionario.AppendChild(coches);

            // coche 1
            XmlElement coche = doc.CreateElement("coche");

            XmlAttribute matricula1 = doc.CreateAttribute("matricula");
            matricula1.Value = "1111AAA";

            XmlElement marca = doc.CreateElement("marca");
            XmlText marcaText1 = doc.CreateTextNode("AUDI");
            marca.AppendChild(marcaText1);

            XmlElement precio = doc.CreateElement("precio");
            XmlText precioText1 = doc.CreateTextNode("30000");
            precio.AppendChild(precioText1);

            coche.SetAttributeNode(matricula1);

            coche.AppendChild(marca);
            coche.AppendChild(precio);

            coches.AppendChild(coche);

            // Coche 2

            XmlElement coche2 = doc.CreateElement("coche");

            XmlAttribute matricula2 = doc.CreateAttribute("matricula");
            matricula2.Value = "2222BBB";

            XmlElement marca2 = doc.CreateElement("marca");
            XmlText marcaText2 = doc.CreateTextNode("SEAT");
            marca2.AppendChild(marcaText2);

            XmlElement precio2 = doc.CreateElement("precio");
            XmlText precioText2 = doc.CreateTextNode("10000");
            precio2.AppendChild(precioText2);

            coche2.SetAttributeNode(matricula2);

            coche2.AppendChild(marca2);
            coche2.AppendChild(precio2);

            coches.AppendChild(coche2);

            // Coche 3

            XmlElement coche3 = doc.CreateElement("coche");

            XmlAttribute matricula3 = doc.CreateAttribute("matricula");
            matricula3.Value = "3333CCC";

            XmlElement marca3 = doc.CreateElement("marca");
            XmlText marcaText3 = doc.CreateTextNode("BMW");
            marca3.AppendChild(marcaText3);

            XmlElement precio3 = doc.CreateElement("precio");
            XmlText precioText3 = doc.CreateTextNode("20000");
            precio3.AppendChild(precioText3);

            coche3.SetAttributeNode(matricula3);

            coche3.AppendChild(marca3);
            coche3.AppendChild(precio3);

            coches.AppendChild(coche3);

            // Coche 4

            XmlElement coche4 = doc.CreateElement("coche");

            XmlAttribute matricula4 = doc.CreateAttribute("matricula");
            matricula4.Value = "4444DDD";

            XmlElement marca4 = doc.CreateElement("marca");
            XmlText marcaText4 = doc.CreateTextNode("TOYOTA");
            marca4.AppendChild(marcaText4);

            XmlElement precio4 = doc.CreateElement("precio");
            XmlText precioText4 = doc.CreateTextNode("10000");
            precio4.AppendChild(precioText4);

            coche4.SetAttributeNode(matricula4);

            coche4.AppendChild(marca4);
            coche4.AppendChild(precio4);

            coches.AppendChild(coche4);

            doc.Save("concesionario.xml");

            Console.WriteLine("Se ha escrito el XML");

            Console.ReadLine();

        }
    }
}
