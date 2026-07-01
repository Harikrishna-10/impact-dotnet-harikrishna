using System;

namespace Task1_16
{
    class Student
    {
        public const string SchoolName = "ABC School";

        public readonly DateTime AdmissionDate;

        private int age;

        public string Name { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 5 && value <= 100)
                    age = value;
                else
                    Console.WriteLine("Invalid Age");
            }
        }

        public Student() : this("Unknown", 5)
        {
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            AdmissionDate = DateTime.Now;
        }

        public void CalculateGrade()
        {
            Console.WriteLine("Grade calculated without marks.");
        }

        public void CalculateGrade(int marks)
        {
            Console.WriteLine($"Marks: {marks}");
        }
    }
}