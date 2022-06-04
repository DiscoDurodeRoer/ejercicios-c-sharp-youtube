using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_basicos_DDR_11
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Escribe una frase");
            String frase = Console.ReadLine();
            
            for (int i = 0; i< frase.Length ;i++)
            {
                Console.WriteLine(frase[i]);
            }
            
            Console.ReadLine();

        }
    }
}
