using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pimpochki.Application.Persistence.EntityRepositories.Common;
using Pimpochki.Infrastructure.Persistence;
using Pimpochki.Infrastructure.Persistence.EntityRepositories.Common;

namespace Pimpochki.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PimpochkiDbContext>(options => {
            options.UseSqlServer(configuration.GetConnectionString("Database"));
        });
        services.AddScoped(typeof(IEntityRepository<>), typeof(EntityRepository<>));
        return services;
    }
}