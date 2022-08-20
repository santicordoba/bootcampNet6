using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17y18.Interfaces
{
    public interface ICerveza : IBebidaAlcoholica
    {
        int IBU { get; set; }
    }
}
