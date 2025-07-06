using Lab5_RetrieveData.Data;
using Microsoft.EntityFrameworkCore;

var context = new AppDbContext();

// 1. Retrieve all products
var products = await context.Products.ToListAsync();
Console.WriteLine("All Products:");
foreach (var p in products)
    Console.WriteLine($"{p.Name} - ₹{p.Price}");

Console.WriteLine();

// 2. Find product by ID
var productById = await context.Products.FindAsync(1);
Console.WriteLine($"Product with ID 1: {productById?.Name}");

// 3. Find first product with price > 50000
var expensiveProduct = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"Expensive Product: {expensiveProduct?.Name}");
