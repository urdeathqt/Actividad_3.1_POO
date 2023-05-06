using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4POO
{
    class Auto:Vehiculo
    {
        private bool airbag;

        public Auto(int id, string marca, string modelo,
                     int km, double precio, bool airbag)
            : base(id, marca, modelo, km, precio)
        {
            this.airbag = airbag;
        }

        public bool Airbag { get => airbag; set => airbag = value; }

        public override double Precio
        {
            get
            {
                if (this.airbag)
                {
                    return base.Precio + 200;
                }
                else
                {
                    return base.Precio;
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
