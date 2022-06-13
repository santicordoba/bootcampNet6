using Clase13.Modelo;

var persona1 = new Persona()
{
    NombreCompleto = "Santiago Córdoba",
    NumeroDNI = "37357015",
    Edad = 28,
    EstaCasado = false,
};


Console.WriteLine(persona1.ObtenerSaludo());
Console.WriteLine(persona1.ObtenerSaludo("Melina"));


var persona2 = new Persona("Melina Marconi", "38706685", 27, false);

Console.WriteLine(persona2.ObtenerSaludo());
Console.WriteLine(persona2.ObtenerSaludo(persona1.NombreCompleto));
