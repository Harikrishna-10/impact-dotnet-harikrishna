using System;

public delegate double MathOperation(double a, double b);

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Custom Delegate =====");

        MathOperation add = Add;
        MathOperation subtract = Subtract;
        MathOperation multiply = Multiply;
        MathOperation divide = Divide;

        Console.WriteLine($"Add: {add(10, 5)}");
        Console.WriteLine($"Subtract: {subtract(10, 5)}");
        Console.WriteLine($"Multiply: {multiply(10, 5)}");
        Console.WriteLine($"Divide: {divide(10, 5)}");

        Console.WriteLine("\n===== Multicast Delegate =====");

        MathOperation operations = Add;
        operations += Multiply;

        operations(4, 2);

        Console.WriteLine("\n===== Func Delegate =====");

        Func<double, double, double> funcAdd = Add;
        Func<double, double, double> funcMultiply = Multiply;

        Console.WriteLine($"Func Add: {funcAdd(4, 2)}");
        Console.WriteLine($"Func Multiply: {funcMultiply(4, 2)}");
    }

    static double Add(double a, double b)
    {
        Console.WriteLine($"Add = {a + b}");
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        Console.WriteLine($"Multiply = {a * b}");
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }
}