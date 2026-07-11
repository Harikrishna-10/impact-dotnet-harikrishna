using System;

class Program
{
    static void Main()
    {
        Money m1 = new Money(100, "USD");
        Money m2 = new Money(200, "USD");

        Money total = m1 + m2;

        Console.WriteLine(total);

        Console.WriteLine(m2 > m1);

        Console.WriteLine(m1 == new Money(100, "USD"));

        try
        {
            Money m3 = new Money(100, "EUR");

            Money result = m1 + m3;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}