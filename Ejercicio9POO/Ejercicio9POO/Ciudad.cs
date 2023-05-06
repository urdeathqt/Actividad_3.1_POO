using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9POO
{
    class Ciudad
    {
        private string nombre;
        private string codigo;

        public Ciudad(string nombre, string codigo)
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
