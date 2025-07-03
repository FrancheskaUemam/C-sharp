using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al programa de clasificación de edad.");
        Console.WriteLine("Por favor, siga las instrucciones para ingresar la edad del usuario.");

        // Llamada al método para clasificar la edad
        ClasificarEdad();
    }
    static void ClasificarEdad()
    {
        Console.WriteLine("Ingrese la edad del usuario:");
        if (int.TryParse(Console.ReadLine(), out int edad))
        {
            if (edad < 0)
            {
                Console.WriteLine("La edad no puede ser negativa.");
            }
            else if (edad < 5)
            {
                Console.WriteLine("El usuario es un bebé.");
            }
            else if (edad < 13 && edad >= 5)
            {
                Console.WriteLine("El usuario es un niño.");
            }
            else if (edad < 18 && edad >= 13)
            {
                Console.WriteLine("El usuario es un adolescente.");
            }
            else if (edad < 65 && edad >= 18)
            {
                Console.WriteLine("El usuario es un adulto.");
            }
            else
            {
                Console.WriteLine("El usuario es un adulto mayor.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero para la edad.");
        }
    }
}