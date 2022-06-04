using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ordenador ordenador = new Ordenador(500);
            ordenador.encender();


            ordenador.aniadirDatos(200);

            ordenador.apagar();

            ordenador.eliminarDatos(100);


            Console.ReadLine();
        }
    }
}
