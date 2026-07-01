using System;

// Implicit Conversion

int number = 100;

long longValue = number;
float floatValue = number;
double doubleValue = number;

Console.WriteLine(longValue);
Console.WriteLine(floatValue);
Console.WriteLine(doubleValue);

// Explicit Conversion

double price = 199.99;

int converted = (int)price;

Console.WriteLine(converted);

// Precision loss because decimal part is removed.

// is operator

object obj = "100";

Console.WriteLine(obj is string);

// as operator

object text = "200";

string result = text as string;

Console.WriteLine(result);

// Convert.ToInt32

string value = "250";

int number1 = Convert.ToInt32(value);

Console.WriteLine(number1);

// TryParse

string input = "500";

if (int.TryParse(input, out int number2))
{
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("Invalid Number");
}