using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13Parte2.Modelo
{
    internal class Auto
    {
        private string _tipoDeMotor;
        private int _anioDeFabricacion;


        public string TipoDeMotor
        {
            get
            {
                return _tipoDeMotor;
            }
            set
            {
                if (value == null || value == "")
                {
                    _tipoDeMotor = "Nafta";
                } else
                {
                    _tipoDeMotor = value;
                }
            }
        }
        public bool EstaEncendido { get; set; }
        public int AnioFabricacion { get; set; }
        public string Marca { get; set; }


    }
}
