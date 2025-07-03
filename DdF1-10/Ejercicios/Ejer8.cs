using System;

namespace DdF1_10
{
    public static class Ejer8
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese los datos del rectángulo:");

            Console.Write("Lado horizontal: ");
            
            double ladorectangulo1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado vertical: ");

            double ladorectangulo2 = Convert.ToDouble(Console.ReadLine());

            double perimetro = (ladorectangulo1 + ladorectangulo2) * 2;

            Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
        }
    }
}
