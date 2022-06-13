using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8_BarajaDeCartas.Model
{
    internal class Baraja
    {
        public List<Naipe> BarajaDe40Naipes;
        public List<Naipe> Monton;

        public Baraja()
        {
            Monton = new List<Naipe>();
            string[] palos = { "Espada", "Basto", "Oro", "Copa" };
            BarajaDe40Naipes = new List<Naipe>();
            foreach(string palo in palos)
            {
                for(int i = 1; i <= 12; i++)
                {
                    if(i != 8 && i != 9)
                    {
                        var naipe = new Naipe(palo, i);
                        BarajaDe40Naipes.Add(naipe);
                    }
                }
            }
        }

        public void Barajar()
        {
            var random = new Random();
            int i = BarajaDe40Naipes.Count;
            while(i > 1)
            {
                i--;
                var posRandom = random.Next(i + 1);
                var naipe = BarajaDe40Naipes[posRandom];
                BarajaDe40Naipes[posRandom] = BarajaDe40Naipes[i];
                BarajaDe40Naipes[i] = naipe;
            }
        }

        public Naipe SiguienteCarta()
        {
            if(BarajaDe40Naipes.Count > 0)
            {
                Naipe carta = BarajaDe40Naipes[0];
                BarajaDe40Naipes.RemoveAt(0);
                Monton.Add(carta);
                return carta;
            } else
            {
                Console.WriteLine("No quedan cartas");
                return null;
            }
        }

        public int CartasDisponibles()
        {
            return BarajaDe40Naipes.Count;
        }

        public List<Naipe> DarCartas(int cantidad)
        {
            if(BarajaDe40Naipes.Count >= cantidad)
            {
                var repartir = new List<Naipe>();
                for(int i = 0; i < cantidad; i++)
                {
                    repartir.Add(BarajaDe40Naipes[0]);
                    Monton.Add(BarajaDe40Naipes[0]);
                    BarajaDe40Naipes.RemoveAt(0);
                }
                return repartir;
            } else
            {
                Console.WriteLine("No hay cartas suficientes");
                return null;
            }

        }

        public void CartasMonton()
        {
            foreach(var naipe in Monton)
            {
                Console.WriteLine(naipe.Numero + " de " + naipe.Palo);
            }
        }

        public void MostrarBaraja()
        {
            foreach(Naipe naipe in BarajaDe40Naipes)
            {
                Console.WriteLine(naipe.Numero + " de " + naipe.Palo);
            }
        }
    }
}
