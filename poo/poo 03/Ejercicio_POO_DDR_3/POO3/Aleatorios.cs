using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    class Aleatorios
    {

        private Random _random;

        public Aleatorios()
        {
            this._random = new Random();
        }

        public int generarNumeroAleatorio(int min, int max)
        {
            if (min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }
            
            return this._random.Next(min, max+1);
        }

        public int[] generarNumerosAleatorios(int longitud, int min, int max)
        {
            if (longitud <= 0)
            {
                return null;
            }

            int[] numeros = new int[longitud];

            for (int i=0; i< numeros.Length ;i++)
            {
                numeros[i] = generarNumeroAleatorio(min, max);
            }

            return numeros;


        }

    }
}
