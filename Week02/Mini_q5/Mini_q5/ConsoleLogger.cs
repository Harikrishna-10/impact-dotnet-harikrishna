using System;

public class ConsoleLogger
{
    public void Log(object sender, string message)
    {
        Console.WriteLine();
        Console.WriteLine("===== EVENT LOG =====");
        Console.WriteLine(message);
    }
}