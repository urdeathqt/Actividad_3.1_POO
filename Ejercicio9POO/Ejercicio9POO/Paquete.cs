using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9POO
{
    class Paquete
    {
        private string codigo;
        private string descripcion;
        private string destinatario;
        private string direccion;

        public Paquete(string codigo, string descripcion, string destinatario, string direccion)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Destinatario = destinatario;
            this.Direccion = direccion;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
