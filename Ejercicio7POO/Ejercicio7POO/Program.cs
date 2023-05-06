using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Persona[] personas = new Persona[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    personas[i] = new Profesor(Console.ReadLine());
                }
                else
                {
                    personas[i] = new Estudiante(Console.ReadLine());
                }
            }

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Profesor)personas[i]).Explicar();

                }
                else
                {
                    ((Estudiante)personas[i]).Estudiar();
                }
            }
        }

        public class Persona
        {
            private string nombre;
            public string Nombre { get => nombre; set => nombre = value; }

            public Persona(string nombre)
            {
                Nombre = nombre;
            }

            public override string ToString()
            {
                return "¡Hola! Mi nombre es " + Nombre;
            }

            ~Persona()
            {
                Nombre = string.Empty;
            }
        }

        public class Profesor : Persona
        {
            public Profesor(string nombre) : base(nombre)
            {
                Nombre = nombre;
            }

            public void Explicar()
            {
                Console.WriteLine("Explicar");
            }
        }

        public class Estudiante : Persona
        {
            public Estudiante(string nombre) : base(nombre)
            {
                Nombre = nombre;
            }

            public void Estudiar()
            {
                Console.WriteLine("Estudiar");
            }
        }
       
    }

}

