using System;

int? number = null;

if (number.HasValue)
{
    Console.WriteLine(number.Value);
}
else
{
    Console.WriteLine("Value is null");
}

ApplyDiscount(null);
ApplyDiscount(15);

void ApplyDiscount(double? discount)
{
    double finalDiscount = discount ?? 5;

    Console.WriteLine($"Discount = {finalDiscount}%");
}