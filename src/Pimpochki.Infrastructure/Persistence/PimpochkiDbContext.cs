using Microsoft.EntityFrameworkCore;

using Pimpochki.Domain.Entities;

namespace Pimpochki.Infrastructure.Persistence;

public class PimpochkiDbContext:DbContext
{
    public PimpochkiDbContext(DbContextOptions<PimpochkiDbContext> options):base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
}