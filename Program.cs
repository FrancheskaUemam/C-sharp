using System;
using System.Collections.Generic;

namespace DdF1_10
{
    class Program
    {
        // Mapa número ‒> acción
        static readonly Dictionary<int, Action> _ejercicios = new()
        {
            { 1, Ejer1.Run },
            { 2, Ejer2.Run },
            { 3, Ejer3.Run },
            { 4, Ejer4.Run },
            { 5, Ejer5.Run },
            { 6, Ejer6.Run },
            { 7, Ejer7.Run },
            { 8, Ejer8.Run },
            { 9, Ejer9.Run },
            { 10, Ejer10.Run }
        };

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("**********************************************************");
            Console.WriteLine(" ¡Hola! ¡Estos son mis 10 primeros ejercicios de C# :)!");
            Console.WriteLine("**********************************************************");
            Console.WriteLine(" Digite un número del 1 al 10 para ejecutar el ejercicio correspondiente.");
            
            if (int.TryParse(Console.ReadLine(), out int n) && _ejercicios.TryGetValue(n, out var accion))
            {
                Console.Clear();
                accion.Invoke();          // Lanza el ejercicio elegido
            }
            else
            {
                Console.WriteLine("Número no válido.");
            }
            Console.WriteLine("Presione '1' para escoger otro ejercicio o cualquier otra tecla para salir.");
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                System.Threading.Thread.Sleep(2000); // Espera un segundo para que el usuario vea el mensaje
                Main(args); // Reinicia el programa para permitir la selección de otro ejercicio
            }
            else
            {
                Console.WriteLine("\n¡Gracias por usar el programa! ¡Hasta luego!");
            }
        }
    }
}
// This code is part of a console application that allows users to select and run different exercises.
// Each exercise is defined in a separate class with a static Run method.