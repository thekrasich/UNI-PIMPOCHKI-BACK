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
        modelBuilder.Entity<Role>().HasData([
            new Role {Id = 1, UserRole = Application.Enums.Role.Customer.ToString()},
            new Role {Id = 2, UserRole = Application.Enums.Role.Admin.ToString()}
        ]);
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
}