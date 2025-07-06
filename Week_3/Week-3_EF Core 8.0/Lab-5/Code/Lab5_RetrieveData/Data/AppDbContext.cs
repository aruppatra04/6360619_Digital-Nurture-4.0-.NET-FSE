using Microsoft.EntityFrameworkCore;
using Lab5_RetrieveData.Models;

namespace Lab5_RetrieveData.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ARUP-04\\SQLEXPRESS;Database=RetailInventory_Lab5;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}

