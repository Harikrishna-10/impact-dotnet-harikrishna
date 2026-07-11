using System;
using System.Collections.Generic;
using System.Globalization;

public static class Extensions
{
    // Extension Method 1
    public static string ToTitleCase(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return value;

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        return textInfo.ToTitleCase(value.ToLower());
    }

    // Extension Method 2
    public static bool IsNullOrEmpty<T>(this List<T> list)
    {
        return list == null || list.Count == 0;
    }

    // Extension Method 3
    public static string ToWords(this int number)
    {
        if (number < 0 || number > 999)
            throw new ArgumentOutOfRangeException("Only numbers from 0 to 999 are supported.");

        if (number == 0)
            return "Zero";

        string[] ones =
        {
            "", "One", "Two", "Three", "Four",
            "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Eleven", "Twelve", "Thirteen",
            "Fourteen", "Fifteen", "Sixteen",
            "Seventeen", "Eighteen", "Nineteen"
        };

        string[] tens =
        {
            "", "", "Twenty", "Thirty",
            "Forty", "Fifty", "Sixty",
            "Seventy", "Eighty", "Ninety"
        };

        string result = "";

        if (number >= 100)
        {
            result += ones[number / 100] + " Hundred ";

            number %= 100;
        }

        if (number >= 20)
        {
            result += tens[number / 10] + " ";

            number %= 10;
        }

        if (number > 0)
        {
            result += ones[number];
        }

        return result.Trim();
    }
}