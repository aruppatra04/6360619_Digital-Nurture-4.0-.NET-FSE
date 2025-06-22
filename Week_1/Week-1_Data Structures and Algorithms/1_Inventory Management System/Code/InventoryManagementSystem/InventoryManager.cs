using System;
using System.Collections.Generic;

public class InventoryManager
{
    private Dictionary<int, Product> _inventory = new();

    public void AddProduct(Product product)
    {
        if (_inventory.ContainsKey(product.ProductId))
        {
            Console.WriteLine("Product with the same ID already exists.");
            return;
        }
        _inventory[product.ProductId] = product;
        Console.WriteLine("Product added.");
    }

    public void UpdateProduct(Product product)
    {
        if (!_inventory.ContainsKey(product.ProductId))
        {
            Console.WriteLine("Product not found.");
            return;
        }
        _inventory[product.ProductId] = product;
        Console.WriteLine("Product updated.");
    }

    public void DeleteProduct(int productId)
    {
        if (_inventory.Remove(productId))
            Console.WriteLine("Product removed.");
        else
            Console.WriteLine("Product not found.");
    }

    public void DisplayAllProducts()
    {
        Console.WriteLine("\nInventory List:");
        foreach (var product in _inventory.Values)
        {
            Console.WriteLine(product);
        }
    }

    public Product FindProduct(int productId)
    {
        return _inventory.TryGetValue(productId, out Product product) ? product : null;
    }
}
