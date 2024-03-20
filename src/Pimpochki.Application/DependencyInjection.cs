using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Pimpochki.Application.Services.Auth.Abstractions;
using Pimpochki.Application.Services.Auth.Implementations;
using Pimpochki.Application.Services.Auth.Options;

namespace Pimpochki.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHashService(configuration);
        services.AddScoped<IAuthService, AuthService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }

    private static IServiceCollection AddHashService(this IServiceCollection services,IConfiguration configuration)
    {
        int saltLength = int.Parse(configuration.GetSection("HashOptions:SaltLength").Value!);
        int keyLength = int.Parse(configuration.GetSection("HashOptions:KeyLength").Value!);
        int iterations = int.Parse(configuration.GetSection("HashOptions:Iterations").Value!);
        
        HashOptions hashOptions = new HashOptions { SaltLength = saltLength, KeyLength = keyLength, Iterations = iterations };
        services.AddSingleton<IHashService>(_ => new HashService(hashOptions));
        return services;
    }

}