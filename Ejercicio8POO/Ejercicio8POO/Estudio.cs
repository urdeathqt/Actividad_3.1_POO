using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8POO
{
    class Estudio
    {
        private string nombre;
        private string direccion;

        public Estudio(string nombre, string direccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
