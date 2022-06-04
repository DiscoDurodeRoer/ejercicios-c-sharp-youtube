using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_funciones_DDR_16
{
    class Program
    {
        static void Main(string[] args)
        {

            int pos = 3;
            Console.WriteLine(NumeroFibonacci(pos));

            Console.ReadLine();

        }

        // 1 1 2 3 5 8 13 21 ...
        public static int NumeroFibonacci(int posicion)
        {
            if (posicion > 0)
            {
                int num1 = 0, num2 = 1, suma = 1;

                for (int i = 1; i < posicion; i++)
                {
                    suma = num1 + num2;

                    num1 = num2;

                    num2 = suma;

                }


                return suma;
            }

            return -1;
           

        }
    }
}
