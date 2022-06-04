using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO7
{
    class Coche:Vehiculo
    {

        private bool _airbag;

        public Coche(int id, string marca, string modelo, int km, double precio, bool airbag)
            :base(id,marca,modelo, km, precio)
        {
            this.airbag = airbag;
        }

        public bool airbag { get => _airbag; set => _airbag = value; }

        public override double precio
        {
            get
            {
                if (this.airbag)
                {
                    return base.precio + 200;
                }
                else
                {
                    return base.precio;
                }
            }
        }

        public override string ToString()
        {
            if (this.airbag)
            {
                return base.ToString() + " y tiene airbag";
            }
            else
            {
                return base.ToString() + " y no tiene airbag";
            }
        }


    }
}
