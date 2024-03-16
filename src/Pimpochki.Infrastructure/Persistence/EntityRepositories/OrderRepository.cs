using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Domain.Entities;
using Pimpochki.Infrastructure.Persistence.EntityRepositories.Common;

namespace Pimpochki.Infrastructure.Persistence.EntityRepositories;

public class OrderRepository:EntityRepository<Order>,IOrderRepository
{
    private readonly PimpochkiDbContext _context;

    public OrderRepository(PimpochkiDbContext context):base(context)
    {
        _context = context;
    }

}