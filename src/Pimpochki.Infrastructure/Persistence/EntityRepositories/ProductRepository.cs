using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Domain.Entities;
using Pimpochki.Infrastructure.Persistence.EntityRepositories.Common;

namespace Pimpochki.Infrastructure.Persistence.EntityRepositories;

public class ProductRepository:EntityRepository<Product>,IProductRepository
{
    private readonly PimpochkiDbContext _context;

    public ProductRepository(PimpochkiDbContext context):base(context)
    {
        _context = context;
    }
    
}