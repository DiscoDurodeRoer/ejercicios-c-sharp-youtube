using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class Concesionario
    {

        private Coche[] _coches;
        private int _limite;

        private int _numCoches;

        public Concesionario(int limite)
        {
            this._coches = new Coche[limite];
            _limite = limite;
            _numCoches = 0;
        }



        public void aniadirCoche(Coche c)
        {
            if (c != null && _numCoches < _coches.Length)
            {
                _coches[_numCoches] = c;
                _numCoches++;
            }
        }

        public void mostrarCoches()
        {
            for (int i=0; i< _numCoches; i++)
            {
                Console.WriteLine(_coches[i].ToString());
            }
        }

        public void vaciarCoches()
        {
            this._coches = new Coche[_limite];
            _numCoches = 0;
        }

        public void eliminarCoche(Coche c)
        {
            if (c!= null && _numCoches != 0)
            {

                int posicion = -1;
                for (int i=0; i< _numCoches; i++)
                {
                    if (c.id == _coches[i].id)
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No existe el coche");
                }
                else
                {
                    _coches[posicion] = null;

                    for (int i = posicion;i<_numCoches;i++)
                    {
                        _coches[i] = _coches[i+1];

                    }

                    _numCoches--;

                }

            }
        }

    }
}
