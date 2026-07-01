// See https://aka.ms/new-console-template for more information
using System;

namespace ContactCardApp
{
    struct ContactCard
    {
        public string Name;
        public string Phone;
        public string Email;

        public ContactCard(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContactCard[] contacts = new ContactCard[]
            {
                new ContactCard("Hari", "9876543210", "hari@gmail.com"),
                new ContactCard("John", "9123456780", "john@gmail.com"),
                new ContactCard("ALICE", "9988776655", "alice@gmail.com"),
                new ContactCard("David", "9012345678", "david@gmail.com"),
                new ContactCard("Emma", "9090909090", "emma@gmail.com")
            };

            Console.Write("Enter name to search: ");
            string searchName = Console.ReadLine();

            bool found = false;

            foreach (var contact in contacts)
            {
                if (contact.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nContact Found");
                    Console.WriteLine($"Name  : {contact.Name}");
                    Console.WriteLine($"Phone : {contact.Phone}");
                    Console.WriteLine($"Email : {contact.Email}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}
