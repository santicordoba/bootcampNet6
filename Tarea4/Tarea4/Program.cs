/*Ejercicio

Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios*/

Console.WriteLine("Ingrese la cantidad de columnas.");
int columnas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de filas.");
int filas = int.Parse(Console.ReadLine());

int[,] numeros = new int[filas, columnas];

int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;

Console.WriteLine("_______________________________________");

for (int i = 0; i < lengthFilas; i++)
{
    Console.WriteLine($"Se caragara la fila {i}");
    for(int j = 0; j < lengthColumnas; j++)
    {
        Console.WriteLine($"Ingrese un numero para la posición {j}");
        numeros[i,j] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("_______________________________________");
}


// VECTOR PROMEDIO DE MISMO TAMAÑO QUE LA CANTIDAD DE COLUMNAS
double[] promedios = new double[filas];

for (int i = 0; i < lengthFilas; i++)
{
    double suma = 0d;
    Console.WriteLine($"Se imprimira en pantalla los numeros de la fila {i}");
    for (int j = 0; j < lengthColumnas; j++)
    {
        Console.WriteLine($"Nº de la posición {j} -> {numeros[i,j]}");
        suma += numeros[i, j];
    }
    Console.WriteLine("_______________________________________");
    promedios[i] = suma / columnas;
}


for(int k = 0; k < promedios.Length; k++)
{
    Console.Write($"Promedios para la fila {k} -> ");
    Console.WriteLine(promedios[k]);
}