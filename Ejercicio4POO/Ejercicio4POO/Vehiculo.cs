using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4POO
{
    class Vehiculo
    {
        private int id;
        private string marca;
        private string modelo;
        private int km;
        private double precio;
        private int anio;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public virtual double Precio { get => precio; set => precio = value; }
        public int Anio { get => anio; set => anio = value; }

        public Vehiculo(int id, string marca, string modelo, int anio, double precio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Anio = anio;
        }

        public override string ToString()
        {
            return "Marca: " + marca + ", Modelo: " + modelo + ", Año: " + anio + ", Precio: $" + precio;
        }
    }
}
