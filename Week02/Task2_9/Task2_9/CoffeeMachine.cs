using System;

public class CoffeeMachine
{
    public void MakeCoffee(object sender, AlarmEventArgs e)
    {
        Console.WriteLine($"Coffee started at {e.AlarmTime:T}");
    }
}