using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {

            Concesionario concesionario = new Concesionario(10);

            Coche c1 = new Coche(1,"BMW", "4", 1000, 12000);
            Coche c2 = new Coche(2, "Toyota", "auris", 0, 12000);
            Coche c3 = new Coche(3, "Seat", "Ibiza", 2000, 15000);
            Coche c4 = new Coche(4, "Ferrari", "rosca", 1000, 20000);
            Coche c5 = new Coche(5, "Peugeout", "206", 100000, 30000);

            concesionario.aniadirCoche(c1);
            concesionario.aniadirCoche(c2);
            concesionario.aniadirCoche(c3);
            concesionario.aniadirCoche(c4);
            concesionario.aniadirCoche(c5);

            Console.WriteLine("Todos los coches");
            concesionario.mostrarCoches();

            concesionario.eliminarCoche(c3);
            concesionario.eliminarCoche(c1);

            Console.WriteLine("Elimino dos coches");
            concesionario.mostrarCoches();

            concesionario.aniadirCoche(c3);
            Console.WriteLine("Añadir un coche mas");
            concesionario.mostrarCoches();

            Console.WriteLine("vacio");
            concesionario.vaciarCoches();
            concesionario.mostrarCoches();
            Console.ReadLine();

        }
    }
}
