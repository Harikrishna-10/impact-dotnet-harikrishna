using System;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(1000);

        account.Deposit(500);
        account.Withdraw(200);
        account.Withdraw(2000); // Overdraw
        account.Deposit(-50);   // Invalid

        Console.WriteLine($"Current Balance: {account.GetBalance():C}");

        account.PrintHistory();
    }
}