using System;

public class ElectricCar : Car
{
    public int BatteryCapacity { get; set; }

    public ElectricCar(
        string make,
        string model,
        int year,
        int doors,
        int batteryCapacity)
        : base(make, model, year, doors)
    {
        Console.WriteLine("ElectricCar Constructor");

        BatteryCapacity = batteryCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Battery: {BatteryCapacity} kWh");
    }
}