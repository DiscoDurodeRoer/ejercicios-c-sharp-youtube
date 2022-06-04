using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_funciones_DDR_15
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 5;
            Console.WriteLine(Factorial(num));
            Console.ReadLine();

        }

        public static int Factorial(int numero)
        {
            if (numero > 0)
            {

                int factorial = 1;

                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i; // factorial = factorial * i;
                }

                return factorial;

            }

            return -1;
        }

    }
}
