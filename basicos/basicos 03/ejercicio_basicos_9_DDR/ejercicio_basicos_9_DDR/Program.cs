using System;

namespace ejercicio_basicos_9_DDR
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//En luga de ir de uno en uno, vamos de dos en dos
			for (int i = 2; i <= 100; i += 2)
			{
				Console.WriteLine(i);
			}

			Console.ReadLine();
		}
	}
}
