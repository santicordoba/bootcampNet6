/*1) Generar un número secreto
aleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

2) Pedir al usuario que ingrese un número y que
intente adivinar el número que eligió la computadora.

3) Si el numero ingresado por el usuario es mayor
al número secreto, avisarle que es muy grande y que intente de nuevo y que
vuelva al paso 2.

4) Si el numero ingresado es menor al número
secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

5) Si el número ingresado coincide con el número
secreto, sacar el siguiente mensaje:

"Felicitaciones, has adivinado el número
secreto que era:  [numeroSecreto] "
"Lo has logrado en [n] intentos!!"

Y finalizar el programa.
*/

Console.ForegroundColor = ConsoleColor.Blue;

int numSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

int numUser;

var contador = 0;
Console.WriteLine("#######################################################");
Console.WriteLine("##           Bienvenido a AdiviNumber2000!           ##");
Console.WriteLine("##                                                   ##"); 
Console.WriteLine("##   Debes adivinar el numero que penso la maquina   ##");
Console.WriteLine("#######################################################");
Console.WriteLine("\n");
Console.ResetColor();
do
{
    Console.WriteLine("Por favor ingrese un numero del 1 al 20...");
    numUser = Int16.Parse(Console.ReadLine());
    contador++;
    if(numUser > numSecreto)
    {
        Console.WriteLine("Ups... Te pasaste... intenta de nuevo");
    } else if (numUser < numSecreto)
    {
        Console.WriteLine("Ups... Te quedaste corto... intenta de nuevo");
    }
}
while(numUser != numSecreto);
Console.WriteLine($"Felicitaciones has adivinado el numero secreto que era: {numSecreto} \nLo lograste en {contador} intentos");