using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_funciones_DDR_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos las matrices
            int[,] matrizNumeros = new int[3, 3];
            string[,] matrizString = new string[3, 3];

            // Rellenamos las matrices
            rellenarMatriz(matrizNumeros, 3);
            rellenarMatriz(matrizString, "x");

            // Mostramos la matrices
            mostrarMatriz(matrizNumeros);
            Console.WriteLine("");
            mostrarMatriz(matrizString);

            Console.ReadLine();
        }

        // Rellena la matriz dado un numero
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

        // Rellena la matriz con una cadena dada
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

        // Muestra una matriz
        public static void mostrarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine("");
            }


        }

        // Muestra una matriz
        public static void mostrarMatriz(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }
            
        }


    }
}
