using System;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string make, string model, int year, int doors)
        : base(make, model, year)
    {
        Console.WriteLine("Car Constructor");
        NumberOfDoors = doors;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Car: {Year} {Make} {Model}");
        Console.WriteLine($"Doors: {NumberOfDoors}");
    }
}