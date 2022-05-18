int[] numeros = new int[10];
Console.WriteLine("Bienvenido");
for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Por favor ingrese el numero para la posicion {i}");
    numeros[i] = int.Parse(Console.ReadLine());
}


// FOR PARA RECORRER Y CALCULAR LOS VALORES REQUERIDOS
int suma = 0;
int maxNum = -1;
int minNum = 999999;
double promedio;

for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"El numero ingresado en la posicion {i} es {numeros[i]}");
    suma= suma + numeros[i];
    if(numeros[i] > maxNum)
    {
        maxNum = numeros[i];
    }
    if(numeros[i] < minNum)
    {
        minNum = numeros[i];
    }
}

// HECHO MANUALMENTE

Console.WriteLine($"El numero maximo es: {maxNum}");
Console.WriteLine($"El numero minimo es: {minNum}");
Console.WriteLine($"La sumatoria de los numeros es: {suma}");
Console.WriteLine($"El promedio es: {suma/numeros.Length}");

// HECHO CON LOS METODOS POR DEFECTO

//Console.WriteLine($"El numero maximo es: {numeros.Max()}");
//Console.WriteLine($"El numero minimo es: {numeros.Min()}");
//Console.WriteLine($"La sumatoria de los numeros es: {numeros.Sum()}");
//Console.WriteLine($"El promedio es: {numeros.Average()}");
