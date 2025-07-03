using System;

namespace DdF1_10
{
    public static class Ejer9
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese la distancia en m: " + "m");

            double distancia = Convert.ToDouble(Console.ReadLine());

            double cm = distancia * 100;

            Console.WriteLine($"La distancia en cm es: {cm}cm");
        }
    }
}
