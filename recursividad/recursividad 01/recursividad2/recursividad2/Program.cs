using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Console.ReadLine();

        }

        public static int factorial(int n)
        {

            if (n == 1)
            {
                return n;
            }
            else
            {
                return n * factorial(n - 1);
            }


        }

    }
}
