using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17y18.Interfaces
{
    public interface IBebida
    {
        decimal Volumen { get; set; }
        bool Gasificada { get; set; }
        string Color { get; set; }
        decimal Calorias { get; set; }
        bool Alcoholica { get; set; }
    }
}
