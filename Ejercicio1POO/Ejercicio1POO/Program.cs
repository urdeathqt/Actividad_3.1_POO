using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            CasaComercial casaComercial = new CasaComercial(10);

            Vehiculo v1 = new Vehiculo(1, "Mitsubishi", "Eclipse Cross", 2021, 30000);
            Vehiculo v2 = new Vehiculo(2, "Toyota", "Hilux", 2019, 21000);
            Vehiculo v3 = new Vehiculo(3, "Hyundai", "Santa fe", 2022, 27500);
            Vehiculo v4 = new Vehiculo(4, "Ford", "Raptor", 2023, 31750);
            Vehiculo v5 = new Vehiculo(5, "Honda", "CR-V", 2023, 28999);

            casaComercial.aniadirVehiculo(v1);
            casaComercial.aniadirVehiculo(v2);
            casaComercial.aniadirVehiculo(v3);
            casaComercial.aniadirVehiculo(v4);
            casaComercial.aniadirVehiculo(v5);

            Console.WriteLine("Se muestras todos los vehiculos: ");
            casaComercial.mostrarVehiculos();

            
            casaComercial.eliminarVehiculos(v1);
            casaComercial.eliminarVehiculos(v4);

            Console.WriteLine("Vehiculos eliminados...");
            casaComercial.mostrarVehiculos();

            Console.WriteLine("Vacio");
            casaComercial.vaciarVehiculos();

            casaComercial.mostrarVehiculos();

            Console.ReadLine();


        }
    }
}
