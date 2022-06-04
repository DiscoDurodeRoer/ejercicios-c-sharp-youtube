using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_funciones_DDR_14
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 7, 4, 3, 10, 9, 3, 2, 1, 1 };
            Console.WriteLine(posicionMenorArray(array));

            Console.ReadLine();
        }

        public static int posicionMenorArray(int[] array)
        {
            if (array != null && array.Length > 0)
            {

                int menor = array[0];
                int indice = 0;

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < menor)
                    {
                        menor = array[i];
                        indice = i;
                    }
                }

                return indice;

            }

            return -1;


        }
    }
}
