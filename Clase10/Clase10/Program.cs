/**
 * 
 * Clase 10 - Estructuras de datos
 * 
 * 
 **/

/*var miArray = new int[10];

for(int i = 0; i < miArray.Length; i++)
{
    miArray[i] = i;
    Console.WriteLine(miArray[i]);
}

foreach(int i in miArray)
{
    Console.WriteLine(i);
}*/

/*var miLista = new List<string>();

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un nombre");
    string nombre = Console.ReadLine();
    miLista.Add(nombre);
}

foreach(string nombre in miLista)
{
    Console.WriteLine(nombre);
}
*/

/**
 * 
 * Escribir un programa que permita al usuario
 * crear una lista decimal nombres. SearchOption debe ofrecer
 * las siguientes opciones: 
 * - Agregar un elemento (al final o en una posicion dada)
 * - Quitar un elemento 
 * - Mostrar posicion de un elemento
 * - Invertir la lista 
 * 
 **/

var listaNombres = new List<string>();
Console.WriteLine("Bienvenido...");

string opcion;

do
{

    Console.WriteLine("Seleccione una de las siguientes opciones: ");
    Console.WriteLine("1- Agregar un nuevo nombre ");
    Console.WriteLine("2- Quitar un nombre");
    Console.WriteLine("3- Mostrar posicion de un nombre");
    Console.WriteLine("4- Invertir la lista");
    Console.WriteLine("5- Mostrar la lista en pantalla");
    Console.WriteLine("6- Salir");

    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ingrese el nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("Donde desaea agregar el nombre");
            Console.WriteLine("1- Al final de la lista");
            Console.WriteLine("2- En una posición especifica");
            var posOpcion = Console.ReadLine();
            switch (posOpcion)
            {
                case "1":
                    listaNombres.Add(nombre);
                    break;
                case "2":
                    Console.WriteLine("En que posición desea ingresar el nombre");
                    int posicion = int.Parse(Console.ReadLine());
                    listaNombres.Insert(posicion, nombre);
                    break;
            }
            break;
        case "2":
            Console.WriteLine("Ingrese el nombre que desea quitar: ");
            string nombreAQuitar = Console.ReadLine();
            listaNombres.Remove(nombreAQuitar);
            break;
        case "3":
            Console.WriteLine("Ingrese el nombre que quiere consultar:");
            string nombreAConsultar = Console.ReadLine();
            listaNombres.IndexOf(nombreAConsultar);
            break;
        case "4":
            Console.WriteLine("La lista se invertira");
            listaNombres.Reverse();
            break;
        case "5":
            Console.WriteLine("Se imprimira en pantalla la lista");
            foreach (var name in listaNombres)
            {
                Console.WriteLine(name);
            }
            break;
        case "6":
            Console.WriteLine("Saludos");
            break;
        default:
            Console.WriteLine("Opcion Invalida");
            break;
    }

} while (opcion != "6");

