using System;

namespace DdF1_10
{
    public static class Ejer1
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese un número para sumar:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro número para sumar:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine("La suma es: " + suma);
        }
    }
}
