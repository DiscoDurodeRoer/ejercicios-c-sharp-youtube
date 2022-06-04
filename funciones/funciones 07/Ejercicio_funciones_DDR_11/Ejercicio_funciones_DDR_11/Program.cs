using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_funciones_DDR_11
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 7, 4, 3, 10, 9, 3, 2, 1, 2 };
            Console.WriteLine(numMayorArray(array));

            Console.ReadLine();

        }

        public static int numMayorArray(int[] array)
        {
            if (array != null && array.Length > 0)
            {

                int mayor = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > mayor)
                    {
                        mayor = array[i];
                    }
                }

                return mayor;

            }

            return -1;


        }

    }
}
