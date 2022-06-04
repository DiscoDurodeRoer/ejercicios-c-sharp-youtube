using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    class Program
    {
        static void Main(string[] args)
        {

            Aleatorios a = new Aleatorios();


            Console.WriteLine("Genero 20 numero entre 1 y 20");
            for (int i=0; i<20 ;i++)
            {
                Console.WriteLine(a.generarNumeroAleatorio(1,20));
            }

            Console.WriteLine("Genero 20 numeros entre 1 y 20 en un array");
            int[] arr = a.generarNumerosAleatorios(-5, 1, 20);
            for (int i=0; arr!= null && i < arr.Length ;i++)
            {
                Console.WriteLine(arr[i]);
            }


            Console.ReadLine();

        }
    }
}
