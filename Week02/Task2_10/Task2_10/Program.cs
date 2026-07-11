using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Action<string> printUpper =
            message => Console.WriteLine(message.ToUpper());

        Func<int, int, int> multiply =
            (a, b) => a * b;

        Predicate<int> isEven =
            number => number % 2 == 0;

        Console.WriteLine("Uppercase:");

        printUpper("hello delegates");

        Console.WriteLine();

        Console.WriteLine($"Multiply: {multiply(5, 6)}");

        Console.WriteLine();

        List<int> numbers = new List<int>
        {
            1,2,3,4,5,6,7,8,9,10
        };

        Console.WriteLine("Even Numbers Squared:");

        ProcessList(
            numbers,
            isEven,
            n => n * n,
            n => Console.WriteLine(n)
        );
    }

    static void ProcessList(
        List<int> list,
        Predicate<int> filter,
        Func<int, int> transform,
        Action<int> output)
    {
        foreach (int item in list)
        {
            if (filter(item))
            {
                output(transform(item));
            }
        }
    }
}