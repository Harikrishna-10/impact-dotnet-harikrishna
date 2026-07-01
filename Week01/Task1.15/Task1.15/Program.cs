using System;

namespace Task1_15
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintValue(100);
            PrintValue("Hello");
            PrintValue(25.5);
            PrintValue(null);

            Console.WriteLine($"Grade: {CalculateGrade(85)}");

            Order order = new Order
            {
                Status = "Premium",
                Amount = 1500
            };

            Console.WriteLine($"Discount: {GetDiscount(order)}%");
        }

        static void PrintValue(object value)
        {
            switch (value)
            {
                case int i:
                    Console.WriteLine($"Integer: {i}");
                    break;

                case string s:
                    Console.WriteLine($"String: {s}");
                    break;

                case double d:
                    Console.WriteLine($"Double: {d}");
                    break;

                case null:
                    Console.WriteLine("Null Value");
                    break;

                default:
                    Console.WriteLine("Unknown Type");
                    break;
            }
        }

        static string CalculateGrade(int marks) =>
            marks switch
            {
                >= 90 => "A",
                >= 75 => "B",
                >= 50 => "C",
                _ => "Fail"
            };

        static int GetDiscount(Order order) =>
            order switch
            {
                { Status: "Premium", Amount: >= 1000 } => 20,
                { Status: "Premium" } => 10,
                { Amount: >= 1000 } => 5,
                _ => 0
            };
    }

    class Order
    {
        public string Status { get; set; }
        public double Amount { get; set; }
    }
}