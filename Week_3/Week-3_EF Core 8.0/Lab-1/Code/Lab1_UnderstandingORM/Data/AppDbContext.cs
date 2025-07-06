using Microsoft.EntityFrameworkCore;
using Lab1_UnderstandingORM.Models;

namespace Lab1_UnderstandingORM.Data;
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ARUP-04\\SQLEXPRESS;Database=RetailInventory_Lab1;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
