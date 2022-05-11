Console.Write("Ingresa tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Hello "+ nombre );

// Datos Numericos

byte numeroByte = 10;
int numeroInteger = 3;
long numeroLong = 2;
double numeroDouble = 1.5;
float numeroFloat = 0.5F;

String texto = "Mostraré la tabla del 2";
Console.WriteLine(texto);
for(int i = 1; i <= numeroByte; i++)
{
    Console.WriteLine("2 x "+i + " = " + i*2);
}

Console.WriteLine(numeroFloat);

public static long puzzle(long N)
{
    long A = 1;
    long B = 1;
    long C = 1;
    long D = 1;
    long X = 0;
    for (long i = 0; i < N; i++)
    {
        X = D + 2 * C + 3 * B + 4 * A;
        A = B;
        B = C;
        C = D;
        D = X;
    }
    return D % 10000000000;
}

Console.WriteLine(puzzle(10));