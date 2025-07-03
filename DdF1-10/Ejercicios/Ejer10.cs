using System;

namespace DdF1_10
{
    public static class Ejer10
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese un número para saber si es positivo o negativo:");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("El número es cero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }
        }
    }
}