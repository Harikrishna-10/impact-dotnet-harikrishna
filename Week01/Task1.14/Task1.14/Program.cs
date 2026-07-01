using System;

namespace Task1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 20, 5, 15, 40, 10 };

            var result = GetMinMax(numbers);

            Console.WriteLine($"Min = {result.Min}");
            Console.WriteLine($"Max = {result.Max}");

            var (name, age, department) = GetEmployee();

            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Department : {department}");
        }

        static (int Min, int Max) GetMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }

            return (min, max);
        }

        static (string Name, int Age, string Department) GetEmployee()
        {
            return ("Hari", 22, "Software Development");
        }
    }
}