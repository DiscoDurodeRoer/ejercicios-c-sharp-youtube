using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_matrices_DDR_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz =
   {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            // 00 01 02
            // 10 11 12
            // 20 21 22

            int suma = 0;
            for (int i = 0, j = matriz.GetLength(1) - 1; i < matriz.GetLength(0); i++, j--)
            {
                suma += matriz[i, j];
            }

            Console.WriteLine("La suma es " + suma);


            Console.ReadLine();
        }
    }
}
