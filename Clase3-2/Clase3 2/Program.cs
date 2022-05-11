Console.WriteLine("//   ESTE PROGRAMA CALCULA LA SUPERFICIE DE UN RECTANGULO //");
Console.WriteLine();
Console.WriteLine("- Ingrese la base del rectangulo: ");
double baseR = double.Parse(Console.ReadLine());
Console.WriteLine("- Ingrese la altura del rectangulo: ");
double altura = double.Parse(Console.ReadLine());
double resultado = baseR * altura;
Console.WriteLine("La superficie de su rectangulo es: " + resultado);

bool esMayorADiez = resultado > 10;

if (esMayorADiez)
{
    Console.WriteLine("La superficie es mayor a 10");
} else
{
    Console.WriteLine("La superficie es menor a 10");
}