using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Extension Method 1 =====");

        string text = "hariKRISHNA kanagasundar";

        Console.WriteLine(text.ToTitleCase());

        Console.WriteLine();


        Console.WriteLine("===== Extension Method 2 =====");

        List<int> numbers = new List<int>();

        Console.WriteLine(numbers.IsNullOrEmpty());

        numbers.Add(10);

        Console.WriteLine(numbers.IsNullOrEmpty());

        Console.WriteLine();


        Console.WriteLine("===== Extension Method 3 =====");

        int value = 245;

        Console.WriteLine(value.ToWords());

        Console.WriteLine();


        Console.WriteLine("===== LINQ Projection =====");

        List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Name="Hari",
                MonthlySalary=50000
            },
            new Employee
            {
                Name="John",
                MonthlySalary=70000
            },
            new Employee
            {
                Name="David",
                MonthlySalary=90000
            }
        };

        var annualSalary = employees.Select(employee => new
        {
            employee.Name,
            AnnualSalary = employee.MonthlySalary * 12
        });

        foreach (var employee in annualSalary)
        {
            Console.WriteLine($"{employee.Name} : {employee.AnnualSalary}");
        }

        Console.WriteLine();

        Console.WriteLine("Anonymous types cannot be returned from methods because");
        Console.WriteLine("their type exists only inside the method where they are created.");
        Console.WriteLine("Instead, use a named class, record, tuple, or return object/dynamic.");
    }
}