using System;

class Program
{
    static void Main()
    {
        Repository<Student> studentRepo = new Repository<Student>();

        studentRepo.Add(new Student { Id = 1, Name = "Hari" });
        studentRepo.Add(new Student { Id = 2, Name = "Krishna" });

        Console.WriteLine("Students");

        foreach (var student in studentRepo.GetAll())
            Console.WriteLine(student);

        Repository<Product> productRepo = new Repository<Product>();

        productRepo.Add(new Product { Id = 101, Name = "Laptop" });
        productRepo.Add(new Product { Id = 102, Name = "Mouse" });

        Console.WriteLine("\nProducts");

        foreach (var product in productRepo.GetAll())
            Console.WriteLine(product);
    }
}