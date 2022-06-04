using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursividad1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(suma(5));
            Console.ReadLine();

        }
     
        public static int suma(int n)
        {

            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + suma(n - 1);
            }


        }


    }
}
