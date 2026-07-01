using System;

namespace Task1_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Partial Class
            Employee employee = new Employee
            {
                Name = "Hari"
            };

            employee.Display();

            Console.WriteLine();

            // Access Modifiers
            AccessModifierDemo demo = new AccessModifierDemo();
            demo.ShowMethods();

            Console.WriteLine();

            // Record
            Address address1 = new Address("Anna Nagar", "Chennai", "600040");
            Address address2 = new Address("Anna Nagar", "Chennai", "600040");

            Console.WriteLine(address1 == address2);

            Address address3 = address1 with
            {
                City = "Coimbatore"
            };

            Console.WriteLine(address3);

            Console.WriteLine();

            // Indexer
            Playlist playlist = new Playlist();

            Console.WriteLine(playlist[0]);

            Console.WriteLine(playlist[10]);

            Console.WriteLine(playlist["Perfect"]);

            Console.WriteLine(playlist["Unknown"]);
        }
    }
}