using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO7
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche c = new Coche(1, "BMW", "1", 500, 10000, false);
            Moto m = new Moto(2, "Toyota", "2", 100, 5000, true);

            Console.WriteLine("Precio coche: " + c.precio);
            Console.WriteLine("Precio moto: " + m.precio);

            Console.WriteLine(c.ToString());
            Console.WriteLine(m.ToString());

            Console.ReadLine();

        }
    }
}
