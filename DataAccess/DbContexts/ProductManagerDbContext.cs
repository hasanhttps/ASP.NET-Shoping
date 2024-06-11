using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DbContexts;

public class ProductManagerDbContext : DbContext { 

    // Constructor

    public ProductManagerDbContext(DbContextOptions<ProductManagerDbContext> options) 
        : base(options) {

    }

    // Methods

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductManagerDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    // Tables

    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
