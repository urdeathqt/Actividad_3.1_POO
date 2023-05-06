using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora computadora = new Computadora(500);

            computadora.encender();

            computadora.aniadirDatos(200);

            computadora.apagar();

            computadora.eliminarDatos(100);

            Console.ReadLine();
        }
    }
}
