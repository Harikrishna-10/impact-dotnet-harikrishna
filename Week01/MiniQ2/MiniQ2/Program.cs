// See https://aka.ms/new-console-template for more information
using System;

namespace TemperatureConverter
{
    class Converter
    {
        // Celsius to Fahrenheit and Kelvin
        public void Convert(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"Celsius: {celsius}°C");
            Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");
            Console.WriteLine($"Kelvin: {kelvin:F2} K");
        }

        // Fahrenheit to Celsius and Kelvin
        public void Convert(double fahrenheit, bool isFahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"Fahrenheit: {fahrenheit}°F");
            Console.WriteLine($"Celsius: {celsius:F2}°C");
            Console.WriteLine($"Kelvin: {kelvin:F2} K");
        }

        // Kelvin to Celsius and Fahrenheit
        public void Convert(double kelvin, char unit)
        {
            double celsius = kelvin - 273.15;
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Kelvin: {kelvin} K");
            Console.WriteLine($"Celsius: {celsius:F2}°C");
            Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();

            Console.WriteLine("=== Celsius Conversion ===");
            converter.Convert(25);

            Console.WriteLine("\n=== Fahrenheit Conversion ===");
            converter.Convert(77, true);

            Console.WriteLine("\n=== Kelvin Conversion ===");
            converter.Convert(300, 'K');
        }
    }
}