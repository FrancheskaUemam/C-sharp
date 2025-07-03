using System;

namespace DdF1_10
{
    public static class Ejer3
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese las notas.");
            
            Console.Write("Nota 1: ");
            
            double nota1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Nota 2: ");
            
            double nota2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Nota 3: ");
            
            double nota3 = Convert.ToDouble(Console.ReadLine());
            
            double promedio = (nota1 + nota2 + nota3) / 3;
            
            Console.WriteLine("El promedio del alumno es: " + promedio);
        }
    }
}
