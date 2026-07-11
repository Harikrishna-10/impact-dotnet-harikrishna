using System;

public class FullTimeEmployee : Employee, ITaxable
{
    public decimal MonthlySalary { get; set; }

    public FullTimeEmployee(
        int id,
        string name,
        string department,
        decimal monthlySalary)
        : base(id, name, department)
    {
        MonthlySalary = monthlySalary;
    }

    public override decimal CalculateSalary()
    {
        return MonthlySalary;
    }

    public decimal CalculateTax()
    {
        return MonthlySalary * 0.10m;
    }
}