/*using Clase15.Modelos;

var objeto1 = new MiClase
{
    id = 1,
    Nombre = "Santiago Córdoba"
};


Console.WriteLine(objeto1.Nombre);

var objeto2 = objeto1;

Console.WriteLine(objeto2.Nombre);

objeto1.Nombre = "Diego Perez";
Console.WriteLine(objeto1.Nombre);
Console.WriteLine(objeto2.Nombre);

*/

using Clase15.Modelos;

var primerPersona = new Persona
{
    Apellido = "Cordoba",
    Nombre = "Santiago"
};

var primerDocente = new Docente
{
    Salario = 70000,
    Nombre = "Facundo",
    Apellido = "Quiroga"
};

var primerAlumno = new Alumno
{
    Nombre = "Nicolas",
    Apellido = "Benz",
    Legajo = 11100
};

var personas = new List<Persona>();

personas.Add(primerPersona);
personas.Add(primerDocente);
personas.Add(primerAlumno);

foreach (var persona in personas)
{
    Console.WriteLine(persona.Nombre);
    var docente = (Docente)persona;
}