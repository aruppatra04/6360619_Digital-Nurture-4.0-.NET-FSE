using Microsoft.EntityFrameworkCore;
using Lab2_DbContextSetup.Models;

namespace Lab2_DbContextSetup.Data;
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ARUP-04\\SQLEXPRESS;Database=RetailInventory_Lab2;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
