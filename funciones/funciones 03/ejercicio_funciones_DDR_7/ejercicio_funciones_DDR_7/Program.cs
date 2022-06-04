using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_funciones_DDR_7
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creamos las matrices
            int[,] matrizNumeros = new int[3, 3];
            string[,] matrizString = new string[3, 3];

            // Llamamos a la funciones
            rellenarMatriz(matrizNumeros, 3);
            rellenarMatriz(matrizString, "x");


            Console.ReadLine();
        }

        // Rellena una matriz dado un numero
        public static void rellenarMatriz(int[,] matriz, int numero)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = numero;
                }
            }


        }

        // Rellena una matriz dado una cadena
        public static void rellenarMatriz(string[,] matriz, string cadena)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = cadena;
                }
            }
        }



    }
}
