using Clase12;  

var alumno1 = new Alumno();


alumno1.Apellido = "Córdoba";
alumno1.Nombre = "Santiago";
alumno1.Legajo = 11125;
alumno1.DNI = "37357015";
alumno1.Calificaciones = new List<int>();

var alumno2 = new Alumno()
{
    Apellido = "Marconi",
    Nombre = "Melina",
    Legajo = 12345,
    DNI = "38706685",
    FechaNacimiento = new DateTime(1995, 1, 31),
    Calificaciones = new List<int>()
};

alumno1.GetInfo();
alumno2.GetInfo();

alumno1.CargarCalificacion(4, DateTime.Now);
alumno2.CargarCalificacion(5);
alumno1.CargarCalificacion(8, DateTime.Now);

Console.WriteLine(alumno1.Calificaciones.Count);

Console.WriteLine($"Promedio del alumno {alumno1.Nombre} es {alumno1.ObtenerPromedio()}");