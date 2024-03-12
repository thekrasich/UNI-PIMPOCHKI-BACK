using Microsoft.Extensions.DependencyInjection;

namespace Pimpochki.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string databaseConnectionString)
    {
        // Add DbContext
        return services;
    }
}