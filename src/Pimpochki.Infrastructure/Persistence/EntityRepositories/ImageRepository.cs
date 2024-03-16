using System.Net.Mime;
using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Domain.Entities;
using Pimpochki.Infrastructure.Persistence.EntityRepositories.Common;

namespace Pimpochki.Infrastructure.Persistence.EntityRepositories;

public class ImageRepository:EntityRepository<Image>,IImageRepository
{
    private readonly PimpochkiDbContext _context;

    public ImageRepository(PimpochkiDbContext context):base(context)
    {
        _context = context;
    }
}