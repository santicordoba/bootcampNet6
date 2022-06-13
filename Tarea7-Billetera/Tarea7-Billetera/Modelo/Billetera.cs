using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7_Billetera.Modelo
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public Billetera()
        {
            Console.WriteLine("Ingrese la cantidad de billetes de 10:");
            BilletesDe10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 20:");
            BilletesDe20 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 50:");
            BilletesDe50 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 100:");
            BilletesDe100 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 200:");
            BilletesDe200 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 500:");
            BilletesDe500 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 1000:");
            BilletesDe1000 = int.Parse(Console.ReadLine());
            Console.WriteLine("Billetera creada exitosamente");
        }

        public Billetera(int cant10, int cant20, int cant50, int cant100, int cant200, int cant500, int cant1000)
        {
            BilletesDe10 = cant10;
            BilletesDe20 = cant20;
            BilletesDe50 = cant50;
            BilletesDe100 = cant100;
            BilletesDe200 = cant200;
            BilletesDe500 = cant500;
            BilletesDe1000 = cant1000;
        }

        public decimal Total()
        {
            var total = BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 * 1000;
            return total;
        }

        public void resetearBilletera()
        {
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }

        public Billetera Combinar(Billetera otraBilletera)
        {
            int b10total = BilletesDe10 + otraBilletera.BilletesDe10;
            int b20total = BilletesDe20 + otraBilletera.BilletesDe20;
            int b50total = BilletesDe50 + otraBilletera.BilletesDe50;
            int b100total = BilletesDe100 + otraBilletera.BilletesDe100;
            int b200total = BilletesDe200 + otraBilletera.BilletesDe200;
            int b500total = BilletesDe500 + otraBilletera.BilletesDe500;
            int b1000total = BilletesDe1000 + otraBilletera.BilletesDe1000;
            Billetera nuevaBilletera = new Billetera(b10total, b20total, b50total, b100total, b200total, b500total,b1000total);
            this.resetearBilletera();
            otraBilletera.resetearBilletera();
            return nuevaBilletera;
        }
    }
}
