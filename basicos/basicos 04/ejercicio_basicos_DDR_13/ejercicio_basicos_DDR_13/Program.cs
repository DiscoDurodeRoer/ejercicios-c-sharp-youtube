using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_basicos_DDR_13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe una frase");
            String frase = Console.ReadLine();

            String fraseMayusculas = "";

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i]>= 'a' && frase[i] <='z')
                {
                    fraseMayusculas += (char)(frase[i] - 32) + "";
                }
                else
                {
                    fraseMayusculas += frase[i];
                }


              
            }

            Console.WriteLine(fraseMayusculas);

            Console.ReadLine();

        }
    }
}
