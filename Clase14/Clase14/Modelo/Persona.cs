using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14.Modelo
{
    internal class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        public Persona()
        {
            nombre = "Juan";
            apellido = "Perez";
        }
    }
}
