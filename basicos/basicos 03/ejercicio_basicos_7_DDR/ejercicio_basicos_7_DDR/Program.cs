using System;

namespace ejercicio_basicos_7_DDR
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Declaramos la variable que vamos a utilizar
			int i = 1;
			while ( i<=100 ) //Equivalente: i<101
			{
				//Escribe en consola el valor de i
				Console.WriteLine(i);
				i++; // i = i + 1;
			}

			Console.ReadLine();
		}
	}
}
