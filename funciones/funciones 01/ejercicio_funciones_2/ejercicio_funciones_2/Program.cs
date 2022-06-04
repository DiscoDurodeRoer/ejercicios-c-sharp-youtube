using System;

namespace ejercicio_funciones_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int resultado = suma(5,7); //Llamada de la función, lo guardo en una variable
			Console.WriteLine(resultado); 
			Console.ReadLine();
		}

		//Función que nos devuelve la suma de dos números
		public static int suma(int num1, int num2) {

			int resultado = num1 + num2;
			return resultado;
		}
			
	}
}
