using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8POO
{
    class Pelicula
    {
        private string nombre;
        private int anio;

        public Pelicula(string nombre, int anio)
        {
            this.Nombre = nombre;
            this.Anio = anio;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Anio { get => anio; set => anio = value; }
    }
}
