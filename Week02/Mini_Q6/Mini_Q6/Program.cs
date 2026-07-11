using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>
        {
            new Book { Title="C# in Depth", Author="Jon Skeet", Genre="Programming", Year=2019, IsAvailable=true },
            new Book { Title="CLR via C#", Author="Jeffrey Richter", Genre="Programming", Year=2012, IsAvailable=true },
            new Book { Title="Clean Code", Author="Robert Martin", Genre="Programming", Year=2008, IsAvailable=false },
            new Book { Title="The Pragmatic Programmer", Author="Andrew Hunt", Genre="Programming", Year=1999, IsAvailable=true },
            new Book { Title="Harry Potter", Author="J.K. Rowling", Genre="Fantasy", Year=1997, IsAvailable=true },
            new Book { Title="The Hobbit", Author="J.R.R. Tolkien", Genre="Fantasy", Year=1937, IsAvailable=false },
            new Book { Title="The Lord of the Rings", Author="J.R.R. Tolkien", Genre="Fantasy", Year=1954, IsAvailable=true },
            new Book { Title="Atomic Habits", Author="James Clear", Genre="Self Help", Year=2018, IsAvailable=true },
            new Book { Title="Deep Work", Author="Cal Newport", Genre="Self Help", Year=2016, IsAvailable=false },
            new Book { Title="The Alchemist", Author="Paulo Coelho", Genre="Fiction", Year=1988, IsAvailable=true },
            new Book { Title="1984", Author="George Orwell", Genre="Fiction", Year=1949, IsAvailable=true },
            new Book { Title="The Silent Patient", Author="Alex Michaelides", Genre="Thriller", Year=2019, IsAvailable=true },
            new Book { Title="The Da Vinci Code", Author="Dan Brown", Genre="Thriller", Year=2003, IsAvailable=false },
            new Book { Title="Rich Dad Poor Dad", Author="Robert Kiyosaki", Genre="Finance", Year=1997, IsAvailable=true },
            new Book { Title="Think and Grow Rich", Author="Napoleon Hill", Genre="Finance", Year=1937, IsAvailable=true }
        };

        // Task 1
        Console.WriteLine("===== Available Books by J.R.R. Tolkien =====\n");

        var availableBooks = books
            .Where(book => book.Author == "J.R.R. Tolkien" && book.IsAvailable);

        foreach (var book in availableBooks)
        {
            Console.WriteLine($"{book.Title} ({book.Year})");
        }

        // Task 2
        Console.WriteLine("\n===== Books Grouped By Genre =====\n");

        var groupedBooks = books
            .GroupBy(book => book.Genre)
            .Select(group => new
            {
                Genre = group.Key,
                Count = group.Count()
            });

        foreach (var group in groupedBooks)
        {
            Console.WriteLine($"{group.Genre} : {group.Count}");
        }

        // Task 3
        Console.WriteLine("\n===== Oldest Book =====\n");

        var oldestBook = books
            .OrderBy(book => book.Year)
            .First();

        Console.WriteLine($"{oldestBook.Title}");
        Console.WriteLine($"Author : {oldestBook.Author}");
        Console.WriteLine($"Year   : {oldestBook.Year}");

        // Task 4
        Console.WriteLine("\n===== Books After 2010 (Sorted By Title) =====\n");

        var recentBooks = books
            .Where(book => book.Year > 2010)
            .OrderBy(book => book.Title);

        foreach (var book in recentBooks)
        {
            Console.WriteLine($"{book.Title} ({book.Year})");
        }
    }
}