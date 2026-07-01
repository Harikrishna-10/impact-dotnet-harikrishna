using System;

namespace Task1_17
{
    public partial class Employee
    {
        partial void ShowMessage()
        {
            Console.WriteLine("Partial Method Executed");
        }
    }
}