using Clase18.Modelos;

var alumno = new Alumno()
{
    Nombre = "Gabriel",
    Apellido = "Rodriguez",
    DNI = "12345678",
    Legajo = 12345
};

var docente = new Docente()
{
    Nombre = "Gabriel",
    Apellido = "Fernandez",
    DNI = "987654321",
    Horas = 12
};

var listado = new List<IPersona>();
listado.Add(docente);
listado.Add(alumno);

List<IPersona> ObtenerPersonasByNombre(List<IPersona> personaList, string nombre)
{
    var nuevaLista = new List<IPersona>();
    foreach (var persona in personaList)
    {
        if(persona.Nombre == nombre)
        {
            nuevaLista.Add(persona);
        }
    }
    return nuevaLista;
}

string ObtenerDatos(IPersona persona)
{
    var datos = persona.Nombre + " " + persona.Apellido;
    return datos;
}

Console.WriteLine(alumno.Nombre);

Console.WriteLine(ObtenerDatos(alumno));
Console.WriteLine(ObtenerDatos(docente));

var nuevoListado = ObtenerPersonasByNombre(listado, "Gabriel");
Console.WriteLine(nuevoListado.Count);