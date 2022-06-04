using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_arrays_DDR_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valores = { 1, 2, 3, 4, 5, 6 };

            int suma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                suma += valores[i];
            }

            double media = (double) suma / valores.Length;

            Console.WriteLine("La media es " + media);

            Console.ReadLine();
        }
    }
}
