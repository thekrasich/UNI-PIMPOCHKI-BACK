using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pimpochki.Infrastructure.Persistence;

namespace Pimpochki.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PimpochkiDbContext>(options => {
            options.UseSqlServer(configuration.GetConnectionString("Database"));
        });
        return services;
    }
}