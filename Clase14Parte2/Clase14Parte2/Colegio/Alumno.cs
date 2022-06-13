using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14Parte2.Colegio
{
    internal class Alumno : Persona
    {
        public int legajo { get; set; }
        public string Curso { get; set; }
        public string Division { get; set; }

        public string recuperarClave()
        {
            return Clave();
        }

    }
}
