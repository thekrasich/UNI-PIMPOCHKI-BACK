using System.Linq.Expressions;
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Application.Persistence.EntityRepositories.Common;

public interface IEntityRepository<TEntity> where TEntity:EntityBase
{
    IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
    Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>>? filter = null, bool isTracked = false);
    Task InsertAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);

}