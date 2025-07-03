using System;

namespace DdF1_10
{
    public static class Ejer4
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese un número para imprimir su doble:");
            
            double numero = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("El doble de " + numero + " es " + (numero * 2));
        }
    }
}
