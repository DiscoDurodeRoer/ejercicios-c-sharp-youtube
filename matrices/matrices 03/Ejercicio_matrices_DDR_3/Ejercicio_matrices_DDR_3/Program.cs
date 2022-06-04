using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_matrices_DDR_3
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

            Console.WriteLine("Escribe una fila");
            int fila = Convert.ToInt32(Console.ReadLine());

            if (fila >= 0 && fila < matriz.GetLength(0))
            {
                int suma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    suma += matriz[fila, i];
                }

                Console.WriteLine("La suma es " + suma);
            }
            else
            {
                Console.WriteLine("Fila no es valida");
            }

            Console.ReadLine();
        }
    }
}
