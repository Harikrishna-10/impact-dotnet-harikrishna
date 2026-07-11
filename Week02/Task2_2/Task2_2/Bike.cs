using System;

public class Bike : Vehicle
{
    public bool HasSidecar { get; set; }

    public Bike(string make, string model, int year, bool hasSidecar)
        : base(make, model, year)
    {
        Console.WriteLine("Bike Constructor");
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Bike: {Year} {Make} {Model}");
        Console.WriteLine($"Has Sidecar: {HasSidecar}");
    }
}