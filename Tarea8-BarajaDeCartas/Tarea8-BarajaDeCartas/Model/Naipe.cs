using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8_BarajaDeCartas.Model
{
    internal class Naipe
    {
        public string Palo { get; set; }
        public int Numero { get; set; }

        public Naipe(string palo, int numero)
        {
            Palo = palo;
            Numero = numero;
        }
    }
}
