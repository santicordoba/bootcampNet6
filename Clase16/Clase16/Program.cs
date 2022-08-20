using Clase16.Modelo;
using Clase16.Repositorio;

var repositorio = new RepositorioDePersonas();
Console.WriteLine(repositorio.Personas.Count());
repositorio.Insertar(new Empleado()
{
    Nombre = "Santiago",
    Apellido = "Córdoba"
});

Console.WriteLine(repositorio.Personas.Count());