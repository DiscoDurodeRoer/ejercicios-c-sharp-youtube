using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graficos2
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

            return this._random.Next(min, max + 1);
        }

        public int[] generarNumerosAleatorios(int longitud, int min, int max)
        {
            if (longitud <= 0)
            {
                return null;
            }

            int[] numeros = new int[longitud];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = generarNumeroAleatorio(min, max);
            }

            return numeros;


        }

        public int[] generarNumerosAleatoriosNoRepetidos(int longitud, int min, int max)
        {

            if (min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }

            if (longitud <= 0 || (max - min) < longitud - 1)
            {
                return null;
            }

            int[] numeros = new int[longitud];

            bool repetido;
            int numero;
            int indice = 0;

            while (indice < numeros.Length)
            {

                repetido = false;

                numero = generarNumeroAleatorio(min, max);

                for (int i = 0; i < indice; i++)
                {
                    if (numeros[i] == numero)
                    {
                        repetido = true;
                    }
                }

                if (!repetido)
                {
                    numeros[indice] = numero;
                    indice++;
                }


            }

            return numeros;


        }

    }
}
