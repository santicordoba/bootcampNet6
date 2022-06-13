using Clase13Parte2.Modelo;

var miAuto = new Auto();

Console.WriteLine("Ingrese tipo de motor");
string tipoDeMotor = Console.ReadLine();

miAuto.TipoDeMotor = tipoDeMotor;

Console.WriteLine(miAuto.TipoDeMotor);