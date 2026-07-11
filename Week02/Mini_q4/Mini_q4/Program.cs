using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee(1,"Hari","IT",60000),
            new FullTimeEmployee(2,"John","HR",50000),

            new PartTimeEmployee(3,"David","IT",500,80),
            new PartTimeEmployee(4,"Sara","Finance",600,60),

            new ContractEmployee(5,"Alex","Finance",45000),
            new ContractEmployee(6,"Rose","IT",55000)
        };

        Console.WriteLine("========== Employee Payroll ==========\n");

        decimal totalPayroll = 0;

        foreach (Employee employee in employees)
        {
            decimal salary = employee.CalculateSalary();

            totalPayroll += salary;

            Console.WriteLine(
                $"{employee.Name,-10} " +
                $"{employee.Department,-10} " +
                $"Salary : {salary}");

            if (employee is ITaxable taxable)
            {
                Console.WriteLine($"Tax      : {taxable.CalculateTax()}");
            }

            Console.WriteLine();
        }

        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Total Payroll : {totalPayroll}");

        Console.WriteLine("\n========== Department Summary ==========\n");

        var groups = employees
            .GroupBy(employee => employee.Department)
            .Select(group => new
            {
                Department = group.Key,
                Count = group.Count(),
                TotalSalary = group.Sum(employee => employee.CalculateSalary())
            });

        foreach (var group in groups)
        {
            Console.WriteLine(
                $"{group.Department,-10} " +
                $"Employees : {group.Count}   " +
                $"Payroll : {group.TotalSalary}");
        }
    }
}