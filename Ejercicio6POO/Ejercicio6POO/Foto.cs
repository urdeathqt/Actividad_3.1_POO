using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6POO
{
    class Foto
    {
        private int id_foto;
        private double tamanio_MB;
        private string fecha_c;
        private string comentarios;

        public Foto(int id_foto, double tamanio_MB, string fecha_c, string comentarios)
        {
            this.Id_foto = id_foto;
            this.Tamanio_MB = tamanio_MB;
            this.Fecha_c = fecha_c;
            this.Comentarios = comentarios;
        }

        public int Id_foto { get => id_foto; set => id_foto = value; }
        public double Tamanio_MB { get => tamanio_MB; set => tamanio_MB = value; }
        public string Fecha_c { get => fecha_c; set => fecha_c = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }


    }
}
