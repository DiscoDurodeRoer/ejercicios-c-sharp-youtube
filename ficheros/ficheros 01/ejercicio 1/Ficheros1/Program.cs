using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficheros1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StreamReader sr = new StreamReader("ejemplo.txt");

                string linea;

                while ((linea = sr.ReadLine()) != null)
                {
                    System.Console.WriteLine(linea);
                }

                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se ha encontrado el archivo");
            }

            Console.ReadLine();

        }
    }
}
