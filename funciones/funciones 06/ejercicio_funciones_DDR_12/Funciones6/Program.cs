using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ConvertirBaseXbaseY(10, 10, 2)); // 1010
            Console.WriteLine(ConvertirBaseXbaseY(60, 10, 8)); // 74
            Console.WriteLine(ConvertirBaseXbaseY(100000, 2, 10)); // 32
            Console.WriteLine(ConvertirBaseXbaseY(12, 3, 2)); // 101
            Console.WriteLine(ConvertirBaseXbaseY(10, 2, 8)); // 1010
            Console.ReadLine();
        }

        public static long ConvertirBaseXbaseY(long numero, int basex, int basey)
        {

            if (basex >= 2 && basex <= 10 && basey >= 2 && basey <= 10)
            {
                long numeroConvertir = 0;

                if (basex == 10 || basey == 10)
                {

                    long digito = 0;
                    int divisor = basey;
                    for (long i = numero, j = 0; i > 0; i /= divisor, j++)
                    {
                        digito = i % divisor;
                        numeroConvertir += digito * (int)Math.Pow(basex, j);
                    }

                }
                else
                {
                    long numeroConvertirDec = ConvertirBaseXbaseY(numero, basex, 10);
                    numeroConvertir = ConvertirBaseXbaseY(numeroConvertirDec, 10, basey);
                }

                return numeroConvertir;

            }
            else
            {
                return -1;
            }

            

        }


    }
}
