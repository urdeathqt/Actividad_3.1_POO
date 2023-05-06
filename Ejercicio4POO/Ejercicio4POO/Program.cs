using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto(1, "Mitsubishi", "Eclipse Cross", 500, 23750, false);
            Moto m = new Moto(2, "Toyota", "Hilux", 100, 18999, true);

            Console.WriteLine("Precio coche: " + a.Precio);
            Console.WriteLine("Precio moto: " + m.Precio);

            Console.WriteLine(a.ToString());
            Console.WriteLine(m.ToString());

            Console.ReadLine();
        }
    }
}
