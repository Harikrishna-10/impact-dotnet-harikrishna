using System;

public class ContractEmployee : Employee
{
    public decimal ContractAmount { get; set; }

    public ContractEmployee(
        int id,
        string name,
        string department,
        decimal contractAmount)
        : base(id, name, department)
    {
        ContractAmount = contractAmount;
    }

    public override decimal CalculateSalary()
    {
        return ContractAmount;
    }
}