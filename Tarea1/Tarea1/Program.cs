var ok = true;

while(ok)
{
    Console.Clear();

    Console.WriteLine("Ingrese su nombre: ");
    var nombre = Console.ReadLine();

    Console.WriteLine($"Hola, {nombre}");

    Console.WriteLine("¿Desea continuar? Ingrese S en caso de Sí o N en caso de No");
    var respuesta = Console.ReadLine();
    if(respuesta.ToUpper() == "N")
    {
        ok = false;
    } else if(respuesta.ToUpper() == "S")
    {
        ok=true;
    } else
    {
        ok=false;
        Console.WriteLine("La opción ingresada no es valida.");
    }
}


