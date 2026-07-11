using System;

public abstract class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Department { get; set; }

    protected Employee(int id, string name, string department)
    {
        Id = id;
        Name = name;
        Department = department;
    }

    public abstract decimal CalculateSalary();
}