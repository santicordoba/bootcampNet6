using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14Parte2.Colegio
{
    internal class Persona
    {
        public string nombreCompleto { get; set; }
        public int dni { get; set; }

        public Persona()
        {
            nombreCompleto = "Juan Perez";
            dni = 12345;
        }

        protected string Clave()
        {
            return "045asdasda89";
        }
    }
}
