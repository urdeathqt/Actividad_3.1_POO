using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5POO
{
    public class Forma
    {
        protected Ubicacion c;

        public override string ToString()
        {
            return string.Empty;
        }

        public double Area()
        {
            return 0.000;
        }

        public double Perimetro()
        {
            return 0.000;
        }
    }

    public class Ubicacion
    {
        private double x, y;
    }

    public class Rectangulo : Forma
    {
        protected double side1, side2;
    }

    public class Circulo : Forma
    {
        protected double radius;
    }
}

