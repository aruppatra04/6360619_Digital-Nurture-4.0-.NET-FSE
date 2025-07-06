using Lab4_InsertInitialData.Data;
using Lab4_InsertInitialData.Models;

var context = new AppDbContext();

// Create category objects
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

// Add categories to DB
await context.Categories.AddRangeAsync(electronics, groceries);

// Create products and associate with categories
var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

// Add products to DB
await context.Products.AddRangeAsync(product1, product2);

// Save all changes
await context.SaveChangesAsync();

Console.WriteLine("Initial data inserted successfully!");
