using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase29_EF_CodeFirst.Modelo
{
    public class Sucursal : EntidadBase
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public List<Deposito> Depositos { get; set; }
        /*public Domicilio Domicilio { get; set; }*/
    }
}
