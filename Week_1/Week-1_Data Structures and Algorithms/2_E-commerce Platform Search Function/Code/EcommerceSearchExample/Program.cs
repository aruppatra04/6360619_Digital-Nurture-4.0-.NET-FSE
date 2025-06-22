using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product { ProductId = 1, ProductName = "Laptop", Category = "Electronics" },
            new Product { ProductId = 2, ProductName = "Shoes", Category = "Footwear" },
            new Product { ProductId = 3, ProductName = "Phone", Category = "Electronics" },
            new Product { ProductId = 4, ProductName = "T-Shirt", Category = "Clothing" },
            new Product { ProductId = 5, ProductName = "Watch", Category = "Accessories" }
        };

        Console.WriteLine("Linear Search:");
        var result1 = SearchAlgorithms.LinearSearch(products, "Phone");
        Console.WriteLine(result1 != null ? result1.ToString() : "Product not found");

        Console.WriteLine("\nBinary Search (Sorted):");
        var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
        var result2 = SearchAlgorithms.BinarySearch(sortedProducts, "Phone");
        Console.WriteLine(result2 != null ? result2.ToString() : "Product not found");
    }
}
