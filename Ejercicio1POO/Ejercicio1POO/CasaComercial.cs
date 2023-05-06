using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1POO
{
    class CasaComercial
    {
        private Vehiculo[] vehiculos;
        private int limite;
        private int totalVehiculos;

        public CasaComercial(int limite)
        {
            this.Vehiculos = new Vehiculo[limite];
            this.Limite = limite;
            totalVehiculos = 0;
        }

        public int Limite { get => limite; set => limite = value; }
        internal Vehiculo[] Vehiculos { get => vehiculos; set => vehiculos = value; }
        public int TotalVehiculos { get => totalVehiculos; set => totalVehiculos = value; }

        public void aniadirVehiculo (Vehiculo v)
        {
            if (v != null && totalVehiculos < vehiculos.Length)
            {
                vehiculos[totalVehiculos] = v;
                totalVehiculos++;
            }

        }

        public void mostrarVehiculos ()
        {
            for (int i = 0; i < totalVehiculos; i++)
            {
                Console.WriteLine(vehiculos[i].ToString());
            }
        }

        public void vaciarVehiculos ()
        {
            this.vehiculos = new Vehiculo[limite];
            totalVehiculos = 0;
        }

        public void eliminarVehiculos(Vehiculo v)
        {
            if (v!= null && totalVehiculos != 0)
            {
                int posicion = -1;

                for (int i = 0; i < totalVehiculos; i++)
                {
                    if (v.Id == vehiculos[i].Id)
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("Vehiculo no encontrado");
                }
                else
                {
                    vehiculos[posicion] = null;

                    for (int i = posicion; i < totalVehiculos; i++)
                    {
                        vehiculos[i] = vehiculos[i + 1];
                    }
                    totalVehiculos--;
                }
            }
        }
    }
}
