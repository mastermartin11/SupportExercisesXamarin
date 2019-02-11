using System;
using System.Collections.Generic;
using System.Text;

namespace App27
{
    class Deportista
    {

        public int puntuacion { set; get; }
        public String nombre { set; get; }
        public String deporte { set; get; }
        public int edad { set; get; }

        public Deportista(int puntuacion, string nombre, string deporte, int edad)
        {
            this.puntuacion = puntuacion;
            this.nombre = nombre;
            this.deporte = deporte;
            this.edad = edad;
        }

        public override string ToString()
        {
            return $"{puntuacion} {nombre} {deporte} {edad}";
        }
    }
}
