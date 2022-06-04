using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_arrays_DDR_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];


            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("Escribe un numero en la pos " + i);
                int num = Convert.ToInt32(Console.ReadLine());
                array[i] = num;
                
            }

            Console.WriteLine("Mostrar datos");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.ReadLine();


        }
    }
}
