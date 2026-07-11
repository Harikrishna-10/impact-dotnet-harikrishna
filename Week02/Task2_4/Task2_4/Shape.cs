using System;

public abstract class Shape
{
    public abstract double CalculateArea();

    public void DisplayArea()
    {
        Console.WriteLine($"Area = {CalculateArea():F2}");
    }
}