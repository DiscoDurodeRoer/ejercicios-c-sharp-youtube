using System;

namespace ejercicio_basicos_10_DDR
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			for (int i = 1; i <= 100; i++)
			{
				if ( (i % 2) == 0 || (i % 3) == 0 )
				{
					Console.WriteLine(i);
				}
			}


			Console.ReadLine();
		}
	}
}
