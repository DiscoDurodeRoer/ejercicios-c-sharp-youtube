using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe un numero decimal");
            int numero = Convert.ToInt32(Console.ReadLine());

            long binario = decimalBinario(numero);
            Console.WriteLine("El numero decimal " + numero + " en binario es "+ binario);

            int decimalB = binarioDecimal(binario);
            Console.WriteLine("El numero binario " + binario + " en decimal es " + decimalB);

            Console.ReadLine();
        }

        public static long decimalBinario(int numero)
        {

            long binario = 0;

            const int DIVISOR = 2;
            long digito = 0;

            for (int i = numero % DIVISOR, j=0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                binario += digito * (long)Math.Pow(10, j);
            }


            return binario;
        }


        public static int binarioDecimal(long binario)
        {

            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;

            for (long i = binario, j = 0; i > 0 ; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }

            return numero;
        }

    }
}
