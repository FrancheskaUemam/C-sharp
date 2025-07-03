using System;

namespace DdF1_10
{
    public static class Ejer6
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese los datos del triángulo en centímetros:");
            
            Console.Write("Base: ");
            
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Altura: ");
            
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            
            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine($"El área del triángulo es: {areaTriangulo} cm²");
        }
    } 
}
