using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"20 Celsius to Fahrenheit is: {TempConverter.CelsiusToFahrenheit(20)}");
            Console.WriteLine($"68 Fahrenheit to Celsius is: {TempConverter.FahrenheitToCelsius(68)}");
        }
    }
}
