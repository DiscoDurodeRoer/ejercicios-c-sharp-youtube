using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_arrays_DDR_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valores = { 4, 3, 7, 10, 1, 5, 7 };

            Array.Sort(valores);

            for (int i=0; i<valores.Length ;i++)
            {
                Console.WriteLine(valores[i]);
            }

            Console.ReadLine();
        }
    }
}
