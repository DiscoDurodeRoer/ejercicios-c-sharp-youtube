using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO_DDR_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Aleatorios a = new Aleatorios();

            int[] numeros = a.generarNumerosAleatoriosNoRepetidos(5, 0, 100);

            if (numeros != null)
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            else
            {
                Console.WriteLine("Revisa los parametros");
            }

            Console.ReadLine();
        }
    }
}
