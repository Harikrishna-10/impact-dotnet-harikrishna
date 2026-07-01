using System;

namespace MiniQ1
{
    internal enum Category
    {
        Electronics,
        Grocery,
        Clothing
    }

    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public Product(string name, decimal price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}