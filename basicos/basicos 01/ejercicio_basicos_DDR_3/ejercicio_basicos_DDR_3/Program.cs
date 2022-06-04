using System;

namespace ejercicio_basicos_DDR_3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Escribe tu nombre");
			String nombre = Console.ReadLine ();

			Console.WriteLine ("Escribe tu edad");
			String texto = Console.ReadLine ();

			int edad = Convert.ToInt32 (texto);

			Console.WriteLine ("Te llamas "+nombre+" y tienes "+edad+ " años");

			Console.ReadLine();
		}
	}
}
