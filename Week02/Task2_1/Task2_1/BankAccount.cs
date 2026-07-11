using System;
using System.Collections.Generic;

public class BankAccount
{
    private decimal balance;
    private List<string> history = new List<string>();

    public BankAccount(decimal initialBalance = 0)
    {
        balance = initialBalance;
        history.Add($"Account created with balance: {balance:C}");
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            history.Add($"Failed Deposit: {amount:C}");
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        balance += amount;
        history.Add($"Deposited: {amount:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            history.Add($"Failed Withdrawal (Invalid Amount): {amount:C}");
            Console.WriteLine("Withdrawal amount must be greater than zero.");
            return;
        }

        if (amount > balance)
        {
            history.Add($"Failed Withdrawal (Overdraw): {amount:C}");
            Console.WriteLine("Insufficient balance.");
            return;
        }

        balance -= amount;
        history.Add($"Withdrawn: {amount:C}");
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void PrintHistory()
    {
        Console.WriteLine("\nTransaction History");

        foreach (var item in history)
        {
            Console.WriteLine(item);
        }
    }
}