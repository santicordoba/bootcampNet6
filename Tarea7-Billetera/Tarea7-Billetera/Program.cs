/*
 * Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)

*/

using Tarea7_Billetera.Modelo;

var billetera1 = new Billetera();

Console.WriteLine($"La billetera tiene {billetera1.Total()}");


var billetera2 = new Billetera();

var billeteraNueva = billetera1.Combinar(billetera2);

Console.WriteLine($"La billetera 1 tiene {billetera1.Total()}");
Console.WriteLine($"La billetera 2 tiene {billetera2.Total()}");
Console.WriteLine($"La billetera nueva tiene {billeteraNueva.Total()}");

