using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche c = new Coche(1, "BMW", "4", 100, 12000);

            Console.WriteLine(c.precio);

            Console.WriteLine(c.marca);

            c.precio = 15000;

            Console.WriteLine(c.precio);

            Console.WriteLine(c.ToString());

            Console.ReadLine();
        }
    }
}
