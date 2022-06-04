using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_arrays_DDR_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valores = { 4, 3, 7, 10, 100, 5, 7 };

            Array.Sort(valores);

            int maximo = valores[valores.Length-1];
            int minimo = valores[0];
            
            
            /*
            int maximo = valores[0];
            int minimo = valores[0];

            for (int i = 1; i<valores.Length; i++)
            {
                if (valores[i] > maximo)
                {
                    maximo = valores[i];
                }

                if (valores[i] < minimo)
                {
                    minimo = valores[i];
                }

            }*/

            Console.WriteLine("El valor minimo es: "+minimo);
            Console.WriteLine("El valor maximo es: "+maximo);

            Console.ReadLine();
        }
    }
}
