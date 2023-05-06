using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9POO
{
    class Camionero
    {
        private string nombre;
        private string telefono;
        private string direccion;
        private string poblacion;
        private float salario;
        private string REC;

        public Camionero(string nombre, string telefono, string direccion, string poblacion, float salario, string REC)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Poblacion = poblacion;
            this.Salario = salario;
            this.REC1 = REC;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public float Salario { get => salario; set => salario = value; }
        public string REC1 { get => REC; set => REC = value; }
    }
}
