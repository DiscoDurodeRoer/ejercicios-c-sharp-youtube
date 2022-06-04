using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursividad4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5 };
            int elementoBuscar = 1;
            int pos = PosicionElementoRecursivo(array, elementoBuscar, 0);
            Console.WriteLine(pos);
            Console.ReadLine();
        }
        
        public static int PosicionElementoRecursivo(int[] array, int elementoBuscar, int indice)
        {

            if (indice == array.Length)
            {
                return -1;
            }else if (array[indice] == elementoBuscar)
            {
                return indice;
            }
            else
            {
                return PosicionElementoRecursivo(array, elementoBuscar, indice + 1);
            }


        }
    }
}
