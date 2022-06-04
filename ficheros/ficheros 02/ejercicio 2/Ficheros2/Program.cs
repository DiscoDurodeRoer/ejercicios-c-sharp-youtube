using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficheros2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                StreamWriter sw = new StreamWriter("ejemplo.txt");

                string[] lineas = {
                    "Hola amigos",
                    "Bienvenidos a un nuevo video de ficheros",
                    "Si te gusto el video, dale a like y subscribete"
                };

                foreach (string linea in lineas)
                {
                    sw.WriteLine(linea);
                }

                sw.Close();

                Console.WriteLine("Fichero escrito");

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
