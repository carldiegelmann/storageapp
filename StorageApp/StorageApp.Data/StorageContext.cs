using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StorageApp.Domain;

namespace StorageApp.Data;

public class StorageContext:DbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<Part> Parts { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderLine> OrderLines { get; set; }

    public DbSet<Invoice> Invoices { get; set; }

    public DbSet<Supplier> Suppliers { get; set; }

    public DbSet<ArticleImage> ArticleImages { get; set; }

    public DbSet<ArticleCategory> ArticleCategories { get; set; }

    public DbSet<Manufacturer> Manufacturers { get; set; }

    public DbSet<Payment> Payment { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = @"Server=localhost;Database=StorageDB;Trusted_Connection=True;MultipleActiveResultSets=True;Integrated Security=True;";
        optionsBuilder.UseSqlServer(connectionString).LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information);
        //se.OnConfiguring(optionsBuilder);
    }
}