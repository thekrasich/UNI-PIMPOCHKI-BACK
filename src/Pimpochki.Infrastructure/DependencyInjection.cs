using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pimpochki.Infrastructure.Persistence;

namespace Pimpochki.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string databaseConnectionString)
    {
        services.AddDbContext<PimpochkiDbContext>(options => options.UseSqlServer(databaseConnectionString,b => b.MigrationsAssembly("Pimpochki.Api")));
        return services;
    }
}