using System;

namespace ejercicio_basicos_DDR_4
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.WriteLine ("Escribeme el primer numero");
			int num1 = Convert.ToInt32(Console.ReadLine ());

			Console.WriteLine ("Escribeme el segundo numero");
			int num2 = Convert.ToInt32(Console.ReadLine ());

			if (num1 >= num2) {
				Console.WriteLine ("El primer numero es mayor o igual que el segundo");
			} else {
				Console.WriteLine ("El segundo numero es mayor que el primero");
			}

			Console.ReadLine ();
		}
	}
}
