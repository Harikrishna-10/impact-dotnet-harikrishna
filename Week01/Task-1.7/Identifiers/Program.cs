// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int studentAge = 22;
        string studentName = "Hari";
        double studentMarks = 95.5;
        bool isPassed = true;
        char grade = 'A';

        Console.WriteLine(studentAge);
        Console.WriteLine(studentName);
        Console.WriteLine(studentMarks);
        Console.WriteLine(isPassed);
        Console.WriteLine(grade);

        // int class = 10; // Compiler Error

        int @class = 10;

        Console.WriteLine(@class);
    }
}
