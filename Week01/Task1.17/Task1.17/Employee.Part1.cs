using System;

namespace Task1_17
{
    public partial class Employee
    {
        public string Name { get; set; }

        partial void ShowMessage();

        public void Display()
        {
            Console.WriteLine($"Employee Name: {Name}");
            ShowMessage();
        }
    }
}