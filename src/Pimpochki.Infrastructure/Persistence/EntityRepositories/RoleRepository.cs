using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Domain.Entities;
using Pimpochki.Infrastructure.Persistence.EntityRepositories.Common;

namespace Pimpochki.Infrastructure.Persistence.EntityRepositories;

public class RoleRepository:EntityRepository<Role>,IRoleRepository
{
    private readonly PimpochkiDbContext _context;

    public RoleRepository(PimpochkiDbContext context):base(context)
    {
        _context = context;
    }
}