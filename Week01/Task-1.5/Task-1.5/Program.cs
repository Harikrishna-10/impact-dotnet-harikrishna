// See https://aka.ms/new-console-template for more information
using SchoolManagement;

Student student1 = new Student("Hari");
student1.Display();

// Without using directive
SchoolManagement.Student student2 =
    new SchoolManagement.Student("John");

student2.Display();
