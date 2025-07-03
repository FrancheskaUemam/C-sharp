using System;

namespace DdF1_10
{
    public static class Ejer7
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese los datos del círculo:");
            
            Console.Write("Radio: ");
            
            double radio = Convert.ToDouble(Console.ReadLine());
            
            double area = Math.PI * Math.Pow(radio, 2); 
            //Math.Pow(base, exponente)
            //Devuelve un número especificado elevado a la potencia especificada.
            
            Console.WriteLine($"El área del círculo es: {area}");
        }
    }
}
