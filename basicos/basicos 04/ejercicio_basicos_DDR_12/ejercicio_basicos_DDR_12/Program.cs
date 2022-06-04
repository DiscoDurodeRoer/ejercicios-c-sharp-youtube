using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_basicos_DDR_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una frase");
            String frase = Console.ReadLine();

            String frase_sin_espacios= frase.Replace(" ", "");
            /*
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    frase_sin_espacios += frase[i];
                }
            }*/

            Console.WriteLine(frase_sin_espacios);

            Console.ReadLine();


        }
    }
}
