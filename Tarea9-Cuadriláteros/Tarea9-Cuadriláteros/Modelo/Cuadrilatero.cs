using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9_Cuadriláteros.Modelo
{
    public abstract class Cuadrilatero
    {
        private Punto _coordenada1;
        private Punto _coordenada2;
        private Punto _coordenada3;
        private Punto _coordenada4;

        public Cuadrilatero(Punto coor1, Punto coor2, Punto coor3, Punto coor4)
        {
            _coordenada1 = coor1;
            _coordenada2 = coor2;
            _coordenada3 = coor3;
            _coordenada4 = coor4;
        }

        public abstract float area();
    }
}
