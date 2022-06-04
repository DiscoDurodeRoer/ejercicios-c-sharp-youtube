using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_arrays_DDR_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            int longitud = 10;
            int numeroCoincidencias = 0;

            int[] array1 = new int[longitud];
            int[] array2 = new int[longitud];
            int[] arrayCoincidencias = new int[longitud];

            // Rellenamos los arrays
            Console.WriteLine("Array 1");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = r.Next(1,50);
                Console.WriteLine(array1[i]);
            }

            Console.WriteLine("Array 2");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = r.Next(1, 50);
                Console.WriteLine(array2[i]);
            }

            // Recorremos ambos arrays
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    // Si tenemos una coincidencia
                    if (array1[i] == array2[j])
                    {
                        // Comprobamos si hay ya una coincidencia
                        bool exists = false;
                        for (int z = 0; z < numeroCoincidencias; z++)
                        {
                            if (arrayCoincidencias[z] == array1[i])
                            {
                                exists = true;
                            }
                        }

                        // Sino existe lo agregamos a las coincidencias
                        if (!exists)
                        {
                            arrayCoincidencias[numeroCoincidencias++] = array1[i];
                        }

                    }


                }
            }

            // mostramos las coincidencias
            Console.WriteLine("Coincidencias");
            for (int i = 0; i < numeroCoincidencias; i++)
            {
                Console.WriteLine(arrayCoincidencias[i]);
            }

            // Mostramos un mensaje segun el numero de coincidencias
            if (numeroCoincidencias >= 3)
            {
                Console.WriteLine("¡Felicidades! Has acertado 3 numeros");
            } else {
                Console.WriteLine("Has perdido, necesitas minimo 3 numeros");
            }


            Console.ReadLine();
        }
    }
}
