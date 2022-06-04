using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO7
{
    class Moto:Vehiculo
    {

        private bool _sidecar;

        public Moto(int id, string marca, string modelo, int km, double precio, bool sidecar)
            : base(id, marca, modelo, km, precio)
        {
            this.sidecar = sidecar;
        }

        public bool sidecar { get => _sidecar; set => _sidecar = value; }

        public override double precio
        {
            get
            {
                if (this.sidecar)
                {
                    return base.precio + 50;
                }
                else
                {
                    return base.precio;
                }
            }
        }

        public override string ToString()
        {
            if (this.sidecar)
            {
                return base.ToString() + " y tiene sidecar";
            }
            else
            {
                return base.ToString() + " y no tiene sidecar";
            }
        }

    }
}
