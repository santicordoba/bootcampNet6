using Clase14.Modelo;

Persona p = null;
var personas = new List<Persona>();
for(int i = 0; i < 100000000; i++)
{
    p = new Persona();
    personas.Add(p);
}

personas = null;