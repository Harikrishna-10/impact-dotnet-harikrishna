using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name="Hari", Department="IT", Salary=70000, JoiningDate=new DateTime(2022,1,10)},
            new Employee { Name="John", Department="HR", Salary=45000, JoiningDate=new DateTime(2020,3,12)},
            new Employee { Name="David", Department="IT", Salary=80000, JoiningDate=new DateTime(2019,5,15)},
            new Employee { Name="Sara", Department="Finance", Salary=65000, JoiningDate=new DateTime(2021,7,1)},
            new Employee { Name="Alex", Department="HR", Salary=52000, JoiningDate=new DateTime(2018,2,20)},
            new Employee { Name="Priya", Department="IT", Salary=90000, JoiningDate=new DateTime(2017,10,5)},
            new Employee { Name="Ravi", Department="Finance", Salary=60000, JoiningDate=new DateTime(2019,6,30)},
            new Employee { Name="Anu", Department="IT", Salary=55000, JoiningDate=new DateTime(2023,4,10)},
            new Employee { Name="Tom", Department="Sales", Salary=48000, JoiningDate=new DateTime(2022,11,11)},
            new Employee { Name="Rose", Department="Sales", Salary=75000, JoiningDate=new DateTime(2020,9,5)}
        };

        Console.WriteLine("Salary > 50000 (Query Syntax)");

        var q1 =
            from employee in employees
            where employee.Salary > 50000
            select employee;

        foreach (var employee in q1)
            Console.WriteLine($"{employee.Name} {employee.Salary}");

        Console.WriteLine("\nSalary > 50000 (Method Syntax)");

        var m1 = employees.Where(employee => employee.Salary > 50000);

        foreach (var employee in m1)
            Console.WriteLine($"{employee.Name} {employee.Salary}");

        Console.WriteLine("\nOrder By Salary Desc (Query)");

        var q2 =
            from employee in employees
            orderby employee.Salary descending
            select employee;

        foreach (var employee in q2)
            Console.WriteLine($"{employee.Name} {employee.Salary}");

        Console.WriteLine("\nOrder By Salary Desc (Method)");

        var m2 = employees.OrderByDescending(employee => employee.Salary);

        foreach (var employee in m2)
            Console.WriteLine($"{employee.Name} {employee.Salary}");

        Console.WriteLine("\nGroup By Department (Query)");

        var q3 =
            from employee in employees
            group employee by employee.Department into department
            select new
            {
                Department = department.Key,
                Count = department.Count(),
                Average = department.Average(employee => employee.Salary)
            };

        foreach (var item in q3)
            Console.WriteLine($"{item.Department} {item.Count} {item.Average}");

        Console.WriteLine("\nGroup By Department (Method)");

        var m3 = employees
            .GroupBy(employee => employee.Department)
            .Select(department => new
            {
                Department = department.Key,
                Count = department.Count(),
                Average = department.Average(employee => employee.Salary)
            });

        foreach (var item in m3)
            Console.WriteLine($"{item.Department} {item.Count} {item.Average}");

        Console.WriteLine("\nProjection (Query)");

        var q4 =
            from employee in employees
            select new
            {
                employee.Name,
                Experience = DateTime.Now.Year - employee.JoiningDate.Year
            };

        foreach (var item in q4)
            Console.WriteLine($"{item.Name} {item.Experience}");

        Console.WriteLine("\nProjection (Method)");

        var m4 = employees.Select(employee => new
        {
            employee.Name,
            Experience = DateTime.Now.Year - employee.JoiningDate.Year
        });

        foreach (var item in m4)
            Console.WriteLine($"{item.Name} {item.Experience}");
    }
}