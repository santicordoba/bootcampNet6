
Console.ForegroundColor = ConsoleColor.Blue;


//  TAREA 1 MEJORADA CON DO WHILE

string opcionElegida;

do
{
    Console.Clear();

    Console.WriteLine("Ingrese su nombre: ");
    var nombre = Console.ReadLine();

    Console.WriteLine($"Hola, {nombre}");

    Console.WriteLine("¿Desea continuar? Ingrese S en caso de Sí o N en caso de No");
    opcionElegida = Console.ReadLine();
    if (opcionElegida.ToUpper() == "N")
    {
        Console.WriteLine("Programa Finalizado correctamente.");
    }
    else if (opcionElegida.ToUpper() != "S")
    {
        Console.WriteLine("La opción ingresada no es valida.");
    }
}
while (opcionElegida.ToUpper() == "S");