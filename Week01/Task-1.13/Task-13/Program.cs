using System;

namespace Task1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // var example
            var name = "Hari";

            // Uncommenting the line below causes a compile-time error
            // name = 100;

            Console.WriteLine($"var value: {name}");

            // dynamic example
            dynamic value = "Hello";
            Console.WriteLine($"{value} - {value.GetType()}");

            value = 100;
            Console.WriteLine($"{value} - {value.GetType()}");

            value = true;
            Console.WriteLine($"{value} - {value.GetType()}");

            Add(10, 20);
            Add("Hello ", "World");
        }

        static void Add(dynamic a, dynamic b)
        {
            Console.WriteLine(a + b);
        }
    }
}