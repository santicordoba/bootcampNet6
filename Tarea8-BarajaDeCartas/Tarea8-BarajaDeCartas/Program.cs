/**
 *Ejercicio de cartas españolas orientado a objetos:

Cada carta tiene un número entre 1 y 12 (el 8 y el 9 no los incluimos) y un palo (espadas, bastos, oros y copas)
La baraja estará compuesta por un conjunto de cartas, 40 exactamente.

Las operaciones que podrá realizar la baraja son:

Barajar():
  Cambia de posición todas las cartas aleatoriamente.

SiguienteCarta():
  Devuelve la siguiente carta que está en la baraja, cuando no haya más o se haya llegado al final, se indica al usuario que no hay más cartas.

CartasDisponibles():
  Indica el número de cartas que aún puede repartir

DarCartas(int cantidad):
  Dado un número de cartas que nos pidan, le devolveremos ese número de cartas (piensa que puedes devolver).
    En caso de que haya menos cartas que las pedidas, no devolveremos nada pero debemos indicárselo al usuario.

CartasMonton():
  Mostramos aquellas cartas que ya han salido, si no ha salido ninguna indicárselo al usuario.

MostrarBaraja():
  Muestra todas las cartas hasta el final. Es decir, si se saca una carta y luego se llama al método, este no mostrara esa primera carta.


Escribir un programa que dentro de un bucle vaya mostrando las opciones que querramos, por ejemplo

1 - Barajar
2 - Mostrar siguiente carta
3 - Mostrar cartas disponibles
4 - Dar cartas
5 - Mostrar cartas del monton
6 - Mostrar baraja
7 - Salir 
 * 
 *
*/

using Tarea8_BarajaDeCartas.Model;

var baraja = new Baraja();

var opcion = 0;
do
{
    Console.WriteLine("Ingrese una opcion: ");
    Console.WriteLine("1- Barajar");
    Console.WriteLine("2- Mostrar Siguiente Carta");
    Console.WriteLine("3- Cantidad de Cartas Disponibles");
    Console.WriteLine("4- Dar Cartas");
    Console.WriteLine("5- Mostrar Cartas del Monton");
    Console.WriteLine("6- Mostrar Baraja");
    Console.WriteLine("7- Salir");
    opcion= int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("");
            Console.WriteLine("Barajando...");
            baraja.Barajar();
            Console.WriteLine("");
            break;
        case 2:
            Naipe naipe = baraja.SiguienteCarta();
            if(naipe != null)
            {
                Console.WriteLine("");
                Console.WriteLine("Se obtuvo la siguiente carta");
                Console.WriteLine(naipe.Numero + " de " + naipe.Palo);
                Console.WriteLine("");
            } else
            {
                Console.WriteLine("");
                Console.WriteLine("No quedan cartas en el maso");
                Console.WriteLine("");
            }
            break;
        case 3:
            Console.WriteLine("");
            Console.WriteLine($"En el maso quedan {baraja.CartasDisponibles()} cartas");
            Console.WriteLine("");
            break;
        case 4:
            Console.WriteLine("");
            Console.WriteLine("Ingrese la cantidad de cartas que quiere tomar del maso: ");
            int cantidad = int.Parse(Console.ReadLine());
            List<Naipe> lista = new List<Naipe>();
            lista = baraja.DarCartas(cantidad);
            if(lista != null)
            {
                Console.WriteLine("Obtuvo las siguientes cartas: ");
                foreach (Naipe n in lista)
                {
                    Console.WriteLine(n.Numero + " de " + n.Palo);
                }
                Console.WriteLine("");
            }
            break;
        case 5:
            Console.WriteLine("");
            Console.WriteLine("Las siguientes cartas estan en el monton: ");
            baraja.CartasMonton();
            Console.WriteLine("");
            break;
        case 6:
            Console.WriteLine("");
            Console.WriteLine("Las siguientes cartas estan en la baraja: ");
            baraja.MostrarBaraja();
            Console.WriteLine("");
            break;
        case 7:
            Console.WriteLine("");
            Console.WriteLine("El programa ha finalizado");
            break;
        default:
            Console.WriteLine("Ingrese una opcion valida");
            break;
    }
}
while(opcion != 7);