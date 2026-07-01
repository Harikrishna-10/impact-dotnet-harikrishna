using System;

namespace Task1_10
{
    [Flags]
    enum FilePermission
    {
        Read = 1,
        Write = 2,
        Execute = 4
    }

    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day number (0-6): ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day >= 0 && day <= 6)
            {
                Console.WriteLine($"Day: {(DaysOfWeek)day}");
            }
            else
            {
                Console.WriteLine("Invalid day number.");
            }

            FilePermission permission = FilePermission.Read | FilePermission.Write;

            Console.WriteLine($"Combined Permissions: {permission}");

            if ((permission & FilePermission.Read) == FilePermission.Read)
            {
                Console.WriteLine("Read Permission Available");
            }

            if ((permission & FilePermission.Write) == FilePermission.Write)
            {
                Console.WriteLine("Write Permission Available");
            }

            if ((permission & FilePermission.Execute) == FilePermission.Execute)
            {
                Console.WriteLine("Execute Permission Available");
            }
            else
            {
                Console.WriteLine("Execute Permission Not Available");
            }
        }
    }
}