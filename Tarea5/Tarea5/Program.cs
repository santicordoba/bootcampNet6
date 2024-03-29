﻿/*

1)      Pedir al usuario la longitud de un vector
2)      Crear el vector del tamaño ingresado.
3)      Llenar el mismo con datos aleatorios
4)      Mostrar el vector por pantalla
5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.
Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.
6)      Mostrar el vector nuevamente.

 */

Console.WriteLine("Por favor ingrese la cantidad de elementos");
int cant = int.Parse(Console.ReadLine());

int[] array = new int[cant];

Random rand = new Random();

for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100);
}

Console.WriteLine();
Console.WriteLine("Se mostrara el array en pantalla");

foreach(int num in array)
{
    Console.WriteLine(num);
}

// FOR PARA INVERTIR LOS VALORES DEL ARRAY

for(int i = 0; i < array.Length / 2; i++)
{
    int indiceDeAtrasParaAdelante = array.Length - i - 1;
    int aux = array[indiceDeAtrasParaAdelante];
    array[indiceDeAtrasParaAdelante] = array[i];
    array[i] = aux;
}

Console.WriteLine();
Console.WriteLine("Se mostrara el array invertido en pantalla");

foreach (int num in array)
{
    Console.WriteLine(num);
}