using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    public class CentrosMedicosList
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}

