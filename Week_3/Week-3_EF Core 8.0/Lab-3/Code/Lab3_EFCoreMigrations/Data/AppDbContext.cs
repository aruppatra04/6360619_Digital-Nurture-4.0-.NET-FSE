using Microsoft.EntityFrameworkCore;
using Lab3_EFCoreMigrations.Models;

namespace Lab3_EFCoreMigrations.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ARUP-04\\SQLEXPRESS;Database=RetailInventory_Lab3;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
