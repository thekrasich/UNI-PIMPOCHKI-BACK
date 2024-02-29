using Microsoft.Extensions.DependencyInjection;

namespace Pimpochki.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}