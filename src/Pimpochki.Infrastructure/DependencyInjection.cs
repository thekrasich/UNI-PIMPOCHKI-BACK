using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Application.Persistence.EntityRepositories.Common;
using Pimpochki.Application.Persistence.EntityServices;
using Pimpochki.Infrastructure.Persistence;
using Pimpochki.Infrastructure.Persistence.EntityRepositories;
using Pimpochki.Infrastructure.Persistence.EntityRepositories.Common;
using Pimpochki.Infrastructure.Persistence.EntityServices;

namespace Pimpochki.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PimpochkiDbContext>(options => {
            options.UseSqlServer(configuration.GetConnectionString("Database"));
        });
        services.AddScoped(typeof(IEntityRepository<>), typeof(EntityRepository<>));
        services.AddScoped<IImageRepository,ImageRepository>();
        services.AddScoped<IOrderRepository,OrderRepository>();
        services.AddScoped<IProductRepository,ProductRepository>();
        services.AddScoped<IRoleRepository,RoleRepository>();
        services.AddScoped<IUserRepository,UserRepository>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IImageService,ImageService>();
        services.AddScoped<IOrderService,OrderService>();
        return services;
    }
}