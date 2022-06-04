using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_funciones_DDR_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            double media = mediaArray(valores);

            Console.WriteLine(media);

            Console.ReadLine();
        }

        public static int sumaArray(int[] array)
        {

            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            return suma;
        }

        public static double mediaArray(int[] array)
        {


            int suma = sumaArray(array);

            double media = (double) suma / array.Length;

            return media;
        }
    }
}
