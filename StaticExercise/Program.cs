using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20); 
            Console.WriteLine($"{celsius}");
            Console.WriteLine($"{fahrenheit}");
        }
    }
}
