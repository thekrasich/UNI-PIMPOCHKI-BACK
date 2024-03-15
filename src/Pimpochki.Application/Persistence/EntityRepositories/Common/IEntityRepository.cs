using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Application.Persistence.EntityRepositories.Common;

public interface IEntityRepository<TEntity> where TEntity:class
{
    Task<List<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(int id);
    Task InsertAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);

}