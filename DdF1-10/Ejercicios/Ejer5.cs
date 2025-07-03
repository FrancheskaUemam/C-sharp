using System;

namespace DdF1_10
{
    public static class Ejer5
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese la temperatura en Celsius:");

            int Celsius = Convert.ToInt32(Console.ReadLine());
            
            double Fahrenheit = (Celsius * 9.0 / 5.0) + 32;
            
            Console.WriteLine($"{Celsius}C° es igual a {Fahrenheit}F° Fahrenheit.");
        }
    }
}