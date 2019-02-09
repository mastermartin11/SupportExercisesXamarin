using System;
using System.Collections.Generic;
using System.Text;

namespace App22
{
    class Proveedor: Persona
    {
        

        public string Nombre { get ; set ; }
        public string Producto { get; set; }

        public Proveedor(string nombre, string producto)
        {
            this.Nombre = nombre;
            this.Producto = producto;
        }
    }
}
