using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Domain.Entities;
using Pimpochki.Infrastructure.Persistence.EntityRepositories.Common;

namespace Pimpochki.Infrastructure.Persistence.EntityRepositories;

public class UserRepository:EntityRepository<User>,IUserRepository
{
    private readonly PimpochkiDbContext _context;

    public UserRepository(PimpochkiDbContext context):base(context)
    {
        _context = context;
    }
    
}