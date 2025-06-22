using System;

class Program
{
    static void Main()
    {
        InventoryManager manager = new InventoryManager();

        manager.AddProduct(new Product { ProductId = 1, ProductName = "Laptop", Quantity = 10, Price = 899.99m });
        manager.AddProduct(new Product { ProductId = 2, ProductName = "Mouse", Quantity = 50, Price = 19.99m });
        manager.AddProduct(new Product { ProductId = 3, ProductName = "Keyboard", Quantity = 30, Price = 49.99m });

        manager.DisplayAllProducts();

        manager.UpdateProduct(new Product { ProductId = 2, ProductName = "Wireless Mouse", Quantity = 45, Price = 24.99m });

        Console.WriteLine("\nUpdated Mouse:");
        Console.WriteLine(manager.FindProduct(2));

        manager.DeleteProduct(3);
        manager.DisplayAllProducts();
    }
}
