using System;

namespace Task1_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Hari", 22);

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);

            student.CalculateGrade();
            student.CalculateGrade(95);

            student.Age = 150; // Validation

            Console.WriteLine(Student.SchoolName);

            Console.WriteLine(student.AdmissionDate);

            // Student.SchoolName = "XYZ"; // Error - const cannot be changed

            // student.AdmissionDate = DateTime.Now; // Error - readonly cannot be changed outside constructor
        }
    }
}