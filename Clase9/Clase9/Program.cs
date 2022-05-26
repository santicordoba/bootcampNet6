Console.WriteLine("Ingrese el tamaño deseado para el listado: ");
int cant = int.Parse(Console.ReadLine());

int[] array = new int[cant];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    // Next(100) nos dara un numero random entre 0 y 100
    array[i] = rand.Next(100);
}

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(i+1 + ": " + array[i]+ " ");
}

Console.WriteLine();
Console.WriteLine("Ingrese posición a modificar: ");
int k = int.Parse(Console.ReadLine());

if(k > array.Length-1 || k < 0)
{
    Console.WriteLine("Ingresaste un indice incorrecto: ");
} else
{
    while (true)
    {
        Console.WriteLine("Ingrese un nuevo valor entre 0 y 100: ");
        int nuevo = int.Parse(Console.ReadLine());
        if(nuevo>0 && nuevo < 100)
        {
            array[k - 1] = nuevo;
            break;
        } else
        {
            Console.WriteLine("Ingreso un numero incorrecto");
        }
    }

    Console.WriteLine();

    int contador = 0;
    foreach (int num in array)
    {
        contador++;
        Console.WriteLine($"{contador}: {num}");
    }
}

