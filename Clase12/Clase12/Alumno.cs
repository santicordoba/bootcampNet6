using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    internal class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public int MyProperty { get; set; }
        public List<int> Calificaciones { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"{this.Nombre}, {this.Apellido}");
        }

        public void CargarCalificacion(int Nota, DateTime Fecha)
        {
            this.Calificaciones.Add(Nota);
            Console.WriteLine(Fecha.ToString("dddd dd-MM-yy"));
        }

        public void CargarCalificacion(int nota)
        {
            this.Calificaciones.Add(nota);
            var Fecha = DateTime.Now;
            Console.WriteLine(Fecha.ToString("dddd dd-MM-yy"));
        }

        public decimal ObtenerPromedio()
        {
            int acumulador = 0;
            foreach(var nota in Calificaciones)
            {
                acumulador += nota;
            }
            var promedio = acumulador / this.Calificaciones.Count;
            return promedio;
        }
    }
}
