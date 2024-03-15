using System.Linq.Expressions;
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Application.Persistence.EntityRepositories.Common;

public interface IEntityRepository<TEntity> where TEntity:EntityBase
{
    IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null, string includeProperties = "");
    Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>>? filter = null, string includeProperties = "", bool isTracked = false);
    TEntity? Get(Expression<Func<TEntity, bool>>? filter = null, string includeProperties = "", bool isTracked = false);
    Task InsertAsync(TEntity entity);
    Task InsertRangeAsync(IEnumerable<TEntity> entities);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void DeleteRange(IEnumerable<TEntity> entities);

}