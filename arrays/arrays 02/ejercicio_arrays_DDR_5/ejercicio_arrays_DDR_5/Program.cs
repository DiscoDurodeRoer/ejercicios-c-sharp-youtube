using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_arrays_DDR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Escribe un numero");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Valor antiguo: " + valores[i]);
                valores[i] *= num;
                Console.WriteLine("Valor nuevo: " + valores[i]);
            }




            Console.ReadLine();
        }
    }
}
