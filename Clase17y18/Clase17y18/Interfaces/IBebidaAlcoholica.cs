using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase17y18.Interfaces;

namespace Clase17y18.Interfaces
{
    public interface IBebidaAlcoholica : IBebida
    {
        decimal Graduacion { get; set; }
    }
}
