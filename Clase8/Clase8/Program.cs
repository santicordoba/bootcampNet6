//Matrices de dos dimensiones

/*int filas = 5;
int columnas = 2;

int[,] notas = new int[filas, columnas];
*/


Console.WriteLine("Bienvenido a la carga de notas de los examenes: ");
Console.WriteLine("Ingrese la cantidad de alumnos: ");
int cantidadAlumnos=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de notas por alumno: ");
int notasPorAlumno= int.Parse(Console.ReadLine());

int[,] notas = new int[cantidadAlumnos,notasPorAlumno];

// Cantidad de filas y de columnas
int lengthFilas = notas.GetUpperBound(0) + 1;
int lengthColumnas = notas.GetUpperBound(1) + 1;

for (int i = 0; i < lengthColumnas; i++)
{
    Console.WriteLine($"Ingrese las notas del alumno nº= {i + 1}");
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.WriteLine($"Ingrese las nota nº= {j + 1}");
        notas[j,i] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("A continuacion se imprimiran las notas de los alumnos en pantalla");
for (int i = 0; i < lengthColumnas; i++)
{
    Console.WriteLine($"Notas del alumno nº= {i + 1}");
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.WriteLine($"Nota: {notas[j,i]}");
    }
}