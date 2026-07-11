using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Method Overloading =====");

        Calculator calculator = new Calculator();

        Console.WriteLine(calculator.Add(10, 20));
        Console.WriteLine(calculator.Add(10.5, 20.5));
        Console.WriteLine(calculator.Add(10, 20, 30));
        Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));

        Console.WriteLine();

        Console.WriteLine("===== Runtime Polymorphism =====");

        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(10, 4)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area = {shape.CalculateArea():F2}");
        }

        Console.WriteLine();

        Console.WriteLine("===== Method Hiding =====");

        Logger logger = new Logger();
        logger.Log();

        FileLogger fileLogger = new FileLogger();
        fileLogger.Log();

        Logger loggerReference = new FileLogger();
        loggerReference.Log();

        Console.WriteLine();

        Console.WriteLine("Explanation:");
        Console.WriteLine("Override -> Runtime chooses derived method.");
        Console.WriteLine("new -> Reference type chooses the method.");
    }
}