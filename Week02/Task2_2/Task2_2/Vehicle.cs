using System;

public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Console.WriteLine("Vehicle Constructor");

        Make = make;
        Model = model;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{Year} {Make} {Model}");
    }
}