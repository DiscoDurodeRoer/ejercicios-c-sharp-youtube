using System;

namespace ejercicio_funciones_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			saludar("Fernando"); //Llamada del método
			Console.ReadLine();
		}

		//Método que saluda
		public static void saludar(string nombre) {

			Console.WriteLine("¡Hola " + nombre + " !"); 
			// Otra forma de hacerlo (Comenta lña anterior linea)
			//Console.WriteLine("¡Hola {0} !", nombre);

		}

	}


}
