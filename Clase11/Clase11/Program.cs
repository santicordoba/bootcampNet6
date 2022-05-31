namespace Clase11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia 1
            Perro firulais = new Perro();
            firulais.Color = "Negro";
            firulais.Edad = 4;
            firulais.Tamanio = "Grande";
            firulais.Raza = "Mastin Napolitano";

            // Instancia 2
            Perro fatiga = new Perro();
            fatiga.Color = "Blanco";
            fatiga.Edad = 2;
            fatiga.Tamanio = "Chico";
            fatiga.Raza = "Maltes";

            // Instancia 2
            Perro cartucho = new Perro();
            cartucho.Color = "Marron";
            cartucho.Edad = 3;
            cartucho.Tamanio = "Medio";
            cartucho.Raza = "ChowChow";

            // Lista de perros
            var perros = new List<Perro>();
            perros.Add(firulais);
            perros.Add(fatiga);
            perros.Add(cartucho);

            /*Console.WriteLine(firulais.Raza);
            Console.WriteLine(fatiga.Raza);
            Console.WriteLine(cartucho.Raza);*/

            foreach(var perro in perros)
            {
                Console.WriteLine(perro.Raza);
                perro.Ladrar();
            }
        }
    }
}