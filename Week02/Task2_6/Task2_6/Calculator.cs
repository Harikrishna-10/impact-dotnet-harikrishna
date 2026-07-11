using System;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Add(params int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}