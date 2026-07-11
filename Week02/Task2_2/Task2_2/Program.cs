using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("----- Electric Car -----");

        ElectricCar tesla = new ElectricCar(
            "Tesla",
            "Model 3",
            2024,
            4,
            75);

        tesla.DisplayInfo();

        Console.WriteLine();

        Console.WriteLine("----- Bike -----");

        Bike bike = new Bike(
            "Royal Enfield",
            "Classic 350",
            2023,
            false);

        bike.DisplayInfo();
    }
}