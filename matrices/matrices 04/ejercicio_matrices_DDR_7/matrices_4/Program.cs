using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices_4
{
    class Program
    {

        static int MINA = 1;
        static int VACIO = 0;

        static void Main(string[] args)
        {

            const int NUMERO_MINAS = 5;
            const int TURNOS_SIN_PISAR = 5;

            bool[,] posicionesMostrar = new bool[6,7];
            int[,] tablero = new int[6,7];

            bool minaPisada = false;
            int turnosSinPisarMinas = 0;

            int n = 0;
            Random r = new Random();
            while (n < NUMERO_MINAS)
            {
                int filaA = r.Next(0, tablero.GetLength(0));
                int columnaA = r.Next(0, tablero.GetLength(1));
                if (tablero[filaA,columnaA] == VACIO)
                {
                    tablero[filaA, columnaA] = MINA;
                    n++;
                }

            }


            while (!minaPisada && turnosSinPisarMinas < TURNOS_SIN_PISAR)
            {

                mostrarTablero(posicionesMostrar, tablero);

                Console.WriteLine("Inserta una fila");
                int fila = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserta una columna");
                int columna = Convert.ToInt32(Console.ReadLine());

                if (tablero[fila, columna] == MINA)
                {
                    Console.WriteLine("Has pisado una mina");
                    minaPisada = true;
                    posicionesMostrar[fila, columna] = true;
                }
                else if (posicionesMostrar[fila, columna])
                {
                    Console.WriteLine("Ya has visitado esta zona");
                }
                else
                {
                    Console.WriteLine("Te has librado, esta vez...");
                    turnosSinPisarMinas++;
                    posicionesMostrar[fila, columna] = true;
                }

            }



            if (minaPisada)
            {
                Console.WriteLine("Has perdido...");
            }
            else
            {
                Console.WriteLine("Has ganado");
            }


            mostrarTablero(posicionesMostrar, tablero);

            Console.ReadLine();
          
        }

        public static void mostrarTablero(bool[,] posicionesMostrar, int[,] tablero)
        {
            for (int i = 0; i < posicionesMostrar.GetLength(0); i++)
            {
                for (int j = 0; j < posicionesMostrar.GetLength(1); j++)
                {
                    if (posicionesMostrar[i,j])
                    {
                        if (tablero[i,j] == VACIO)
                        {
                            Console.Write("V ");
                        }
                        else
                        {
                            Console.Write("M ");
                        }
                    }
                    else
                    {
                        Console.Write("E ");
                    }
                }
                Console.WriteLine("");
            }


        }
        
    }
}
