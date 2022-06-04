using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_matrices_DDR_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo la matriz de 3x3
            int[,] valores = new int[3,3];

            // Recorro las filas
            for (int i = 0; i < valores.GetLength(0); i++)
            {
                // Recorro las columnas
                for (int j = 0; j < valores.GetLength(1); j++)
                {
                    // Genero el numero
                    valores[i, j] = (valores.GetLength(1) * i) + (j + 1);
                    Console.Write(valores[i,j] + " ");
                }
                // Salto de linea
                Console.WriteLine("");

            }
            
            Console.ReadLine();

        }
    }
}
