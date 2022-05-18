string[] autos = { "BWM", "VOLVO", "FORD", "CHEVROLET", "PEUGEOT" };

for (int i = 0; i < autos.Length; i++)
{
    Console.WriteLine($"Auto en la posión {i + 1} -> {autos[i]}");
}

string[] frutas = new string[4];

frutas[0] = "Pera";
frutas[1] = "Manzana";
frutas[2] = "Naranja";
frutas[3] = "Uvas";

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);
}

int[] numeros = new int[5];

Console.WriteLine("Ingrese 5 numeros");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese un numero para la posicion {i}");
    numeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;
for(int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}

Console.WriteLine($"Suma de los numeros cargados: {suma}");