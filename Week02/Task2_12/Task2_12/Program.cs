using System;
using System.Collections.Generic;

class Program
{
    static IEnumerable<int> GetEvenNumbers(int max)
    {
        for (int i = 2; i <= max; i += 2)
            yield return i;
    }

    static void Main()
    {
        Console.WriteLine("Even Numbers");

        foreach (var number in GetEvenNumbers(10))
            Console.Write(number + " ");

        Console.WriteLine("\n");

        BookCollection library = new BookCollection();

        library.Add(new Book { Title = "C# in Depth" });
        library.Add(new Book { Title = "Algorithms" });
        library.Add(new Book { Title = "ASP.NET Core" });

        Console.WriteLine("Books");

        foreach (Book book in library)
            Console.WriteLine(book);
    }
}