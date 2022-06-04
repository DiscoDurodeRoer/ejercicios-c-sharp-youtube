using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_matrices_DDR_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            bool salir = false;

            // creo la matriz
            string[,] tablero = new string[4,4];

            // relleno la matriz
            rellenarMatriz(tablero, "X");

            int posI = 0;
            int posJ = 0;

            // El O esta en la posicion 0,0
            tablero[posI, posJ] = "O";

            while (!salir)
            {
                // opciones
                Console.WriteLine("1. Derecha");
                Console.WriteLine("2. Izquierda");
                Console.WriteLine("3. Abajo");
                Console.WriteLine("4. Arriba");
                Console.WriteLine("5. Salir");

                // Muestro la matriz
                mostrarMatriz(tablero);

                // Pido una opcion
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:

                        // Compruebo si esta dentro de la matriz
                        if(dentroMatriz(posI, posJ+1, tablero))
                        {
                            // Quito la X de donde estoy
                            tablero[posI, posJ] = "X";
                            // Como es derecha, aumento la columna en 1
                            posJ++;
                            // Coloco el O
                            tablero[posI, posJ] = "O";

                        }
                        else
                        {
                            Console.WriteLine("No te puedes salir del tablero");
                        }


                        break;
                    case 2:

                        // Compruebo si esta dentro de la matriz
                        if (dentroMatriz(posI, posJ - 1, tablero))
                        {
                            // Quito la X de donde estoy
                            tablero[posI, posJ] = "X";
                            // Como es izquierda, reduzco la columna en 1
                            posJ--;
                            // Coloco el O
                            tablero[posI, posJ] = "O";

                        }
                        else
                        {
                            Console.WriteLine("No te puedes salir del tablero");
                        }

                        break;
                    case 3:

                        // Compruebo si esta dentro de la matriz
                        if (dentroMatriz(posI+1, posJ, tablero))
                        {
                            // Quito la X de donde estoy
                            tablero[posI, posJ] = "X";
                            // Como es a abajo, aumenta la fila en 1
                            posI++;
                            // Coloco el O
                            tablero[posI, posJ] = "O";

                        }
                        else
                        {
                            Console.WriteLine("No te puedes salir del tablero");
                        }

                        break;
                    case 4:

                        // Compruebo si esta dentro de la matriz
                        if (dentroMatriz(posI - 1, posJ, tablero))
                        {
                            // Quito la X de donde estoy
                            tablero[posI, posJ] = "X";
                            // Como es a arriba, reduzco la fila en 1
                            posI--;
                            // Coloco el O
                            tablero[posI, posJ] = "O";

                        }
                        else
                        {
                            Console.WriteLine("No te puedes salir del tablero");
                        }

                        break;
                    case 5:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Solo opciones entre 1 y 5");
                        break;
                }

            }

            Console.ReadLine();
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

        // Indica si una posicion esta dentro de una matriz
        public static bool dentroMatriz(int posI, int posJ, string[,] matriz)
        {
            return posI >= 0 && posI < matriz.GetLength(0)
                && posJ >= 0 && posJ < matriz.GetLength(1);
        }

    }
}
