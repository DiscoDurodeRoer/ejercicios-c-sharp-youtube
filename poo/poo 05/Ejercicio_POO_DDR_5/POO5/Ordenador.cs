using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class Ordenador
    {

        private int tamanioGB;
        private int tamanioGBMax;
        private bool encendido;

        private const int TAMANIO_DEFECTO = 100;

        public Ordenador(int tamanioGBMax)
        {
            this.tamanioGB = 0;
            this.encendido = false;

            if (tamanioGBMax <= 0)
            {
                this.tamanioGBMax = TAMANIO_DEFECTO;
            }
            else
            {
                this.tamanioGBMax = tamanioGBMax;
            }
        }

        public void aniadirDatos(int datos)
        {
            if (this.encendido)
            {
                if (datos <= 0)
                {
                    Console.WriteLine("Los GB tienen que ser mayor que 0");
                }
                else
                {
                    if (this.tamanioGB + datos >= this.tamanioGBMax)
                    {
                        this.tamanioGB = this.tamanioGBMax;
                        Console.WriteLine("Disco duro lleno");
                    }
                    else
                    {
                        this.tamanioGB += datos;
                        Console.WriteLine("Se ha añadido informacion, actual: " + this.tamanioGB);
                    }
                }
            }
            else
            {
                Console.WriteLine("El ordenador debe estar encendido");
            }
        }

        public void eliminarDatos(int datos)
        {
            if (this.encendido)
            {
                if (datos <= 0)
                {
                    Console.WriteLine("Los GB tienen que ser mayor que 0");
                }
                else
                {
                    if (this.tamanioGB - datos <= 0)
                    {
                        this.tamanioGB = 0;
                        Console.WriteLine("Disco duro vacio");
                    }
                    else
                    {
                        this.tamanioGB -= datos;
                        Console.WriteLine("Se ha eliminado informacion, actual: " + this.tamanioGB);
                    }
                }
            }
            else
            {
                Console.WriteLine("El ordenador debe estar encendido");
            }
        }

        public void encender()
        {
            this.encendido = true;
        }

        public void apagar()
        {
            this.encendido = false;
        }

    }
}
