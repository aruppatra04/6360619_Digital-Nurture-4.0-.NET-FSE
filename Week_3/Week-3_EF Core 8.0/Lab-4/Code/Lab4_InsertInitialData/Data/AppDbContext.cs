using Microsoft.EntityFrameworkCore;
using Lab4_InsertInitialData.Models;

namespace Lab4_InsertInitialData.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ARUP-04\\SQLEXPRESS;Database=RetailInventory_Lab4;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}

