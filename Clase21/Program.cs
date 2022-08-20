// Ejemplo 2

using Clase21;

int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

int todosLosNumeros = numeros.Count();

Console.WriteLine(todosLosNumeros);

int cantImpares = numeros.Count(x => x % 2 != 0);

Console.WriteLine($"Impares totales: {cantImpares}");

// ejemplo 2

List<Cliente> misClientes = new List<Cliente>();
misClientes.Add(new Cliente { Apellido = "Perez", Nombre = "Nicolas" });
misClientes.Add(new Cliente { Apellido = "Perez", Nombre = "Ruben" });
misClientes.Add(new Cliente { Apellido = "Perez", Nombre = "Juan" });
misClientes.Add(new Cliente { Apellido = "Rodriguez", Nombre = "Juan" });

IEnumerable<Cliente> perez = misClientes.Where(
    cadaCliente => cadaCliente.Apellido == "Perez");

foreach(Cliente c in perez)
{
    Console.WriteLine($"{c.Nombre} {c.Apellido}");
}



// Query Expression

int[] puntajes = { 90, 71, 82, 93, 75, 82 };

IEnumerable<int> resultados =
    from puntaje in puntajes
    where puntaje > 80
    orderby puntaje descending
    select puntaje;

foreach(var resultado in resultados)
{
    Console.WriteLine(resultado);
}


