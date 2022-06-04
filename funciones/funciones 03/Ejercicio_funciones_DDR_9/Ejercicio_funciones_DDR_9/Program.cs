using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_funciones_DDR_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4,3];

            Console.WriteLine(dentroMatriz(5, 0, matriz));

            Console.ReadLine();
        }

        // Indica si una posicion esta dentro de una matriz
        public static Boolean dentroMatriz(int posI, int posJ, int[,] matriz)
        {
            return posI >= 0 && posI < matriz.GetLength(0) 
                && posJ >= 0 && posJ < matriz.GetLength(1) ;
        }

    }
}
