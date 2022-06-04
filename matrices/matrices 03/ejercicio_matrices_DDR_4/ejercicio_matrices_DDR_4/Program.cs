using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_matrices_DDR_4
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

            Console.WriteLine("Escribe una columna");
            int columna = Convert.ToInt32(Console.ReadLine());

            if (columna >= 0 && columna < matriz.GetLength(1))
            {
                int suma = 0;
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    suma += matriz[i, columna];
                }

                Console.WriteLine("La suma es " + suma);
            }
            else
            {
                Console.WriteLine("Columna no es valida");
            }

            Console.ReadLine();
        }
    }
}
