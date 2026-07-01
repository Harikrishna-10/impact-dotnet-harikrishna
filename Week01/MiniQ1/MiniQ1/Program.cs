// See https://aka.ms/new-console-template for more information
using MiniQ1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("Laptop", 65000, Category.Electronics),
                new Product("Mobile", 25000, Category.Electronics),
                new Product("Rice", 1200, Category.Grocery),
                new Product("Shirt", 1500, Category.Clothing),
                new Product("Oil", 250, Category.Grocery)
            };

            var groupedProducts = products.GroupBy(p => p.Category);

            foreach (var group in groupedProducts)
            {
                Console.WriteLine($"Category: {group.Key}");

                foreach (var product in group)
                {
                    Console.WriteLine($"  {product.Name} - ₹{product.Price}");
                }

                Console.WriteLine();
            }
        }
    }
}