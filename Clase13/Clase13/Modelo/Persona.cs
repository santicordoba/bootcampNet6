using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13.Modelo
{
    internal class Persona
    {
        public string NombreCompleto { get; set; }
        public string NumeroDNI { get; set; }
        public int Edad { get; set; }
        public bool EstaCasado { get; set; }

        public Persona()
        {
            Console.WriteLine("Se ha instanciado una nueva persona");
        }

        public Persona(string nombreCompleto, string dni, int edad, bool estaCasado)
        {
            NombreCompleto = nombreCompleto;
            NumeroDNI = dni;
            Edad = edad;
            EstaCasado = estaCasado;
        }


        public string ObtenerSaludo()
        {
            return $"Hola me llamo {this.NombreCompleto}";
        }

        public string ObtenerSaludo(string nombrePersonaASaludar)
        {
            return $"Hola {nombrePersonaASaludar}, me llamo {this.NombreCompleto}";

        }



    }
}
