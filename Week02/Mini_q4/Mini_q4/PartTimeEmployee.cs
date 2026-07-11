using System;

public class PartTimeEmployee : Employee
{
    public decimal HourlyRate { get; set; }

    public int HoursWorked { get; set; }

    public PartTimeEmployee(
        int id,
        string name,
        string department,
        decimal hourlyRate,
        int hoursWorked)
        : base(id, name, department)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}