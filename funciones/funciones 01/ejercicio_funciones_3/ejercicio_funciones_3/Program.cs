using System;

namespace ejercicio_funciones_3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(factorial(5)); //Llamo a la función
			Console.ReadLine();
		}

		//Función que devuelve el factorial de un número
		public static int factorial(int num) {

			int resultado = num; //empiezo en el numero
			for (int i = num-1; i>1 ;i--) //empiezo en num-1 y acabo en 1 (no llega a 1)
			{
				resultado *= i;
			}
			return resultado; //devuelvo el resultado

		}

	}
}
