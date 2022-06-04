using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_funciones_DDR_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valores = { 1,2,3,4,5,6,7,8,9,10 };

            mostrarArray(valores);

            Console.ReadLine();
        }

        public static void mostrarArray(int[] array)
        {

            for (int i=0; i<array.Length ;i++)
            {
                Console.WriteLine(array[i]);
            }

        }
        
    }
}
