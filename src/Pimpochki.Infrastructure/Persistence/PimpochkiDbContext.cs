using Microsoft.EntityFrameworkCore;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Infrastructure.Persistence;

public class PimpochkiDbContext:DbContext
{
    public PimpochkiDbContext(DbContextOptions<PimpochkiDbContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Image[] images =
        [
            new Image()
            {
                Id = 1,
                ProductId = 1,
                Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwMGpJzhZ-k2WSmpUGDpOFg57h6-vJbb7oBA&s"
            }
        ];
        Product[] products =
        [
            new Product()
            {
                Id = 1,
                Description = "ERERER",
                Quantity = 3,
            }];
        
        modelBuilder.Entity<Role>().HasData([
            new Role {Id = 1, UserRole = Application.Enums.Role.Customer.ToString()},
            new Role {Id = 2, UserRole = Application.Enums.Role.Admin.ToString()}
        ]);

        modelBuilder.Entity<Image>().HasData(images);
        modelBuilder.Entity<Product>().HasData(products);

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
}