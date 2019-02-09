using System;
using System.Collections.Generic;
using System.Text;

namespace App22
{
    class Cliente:Persona
    {
        



        public Cliente(string nombre, string dni)
        {
            Nombre = nombre;
            DNI1 = dni;
        }

        public string Nombre { get; set; }
        public string DNI1 { get; set; }
    }
}
