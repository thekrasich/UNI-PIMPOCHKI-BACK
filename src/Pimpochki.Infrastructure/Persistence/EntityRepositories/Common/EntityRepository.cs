using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Pimpochki.Application.Persistence.EntityRepositories.Common;
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Infrastructure.Persistence.EntityRepositories.Common;

public class EntityRepository<TEntity>:IEntityRepository<TEntity> where TEntity: EntityBase
{
     private readonly PimpochkiDbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public EntityRepository(PimpochkiDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        
        
        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (filter is not null) 
            {
                query = query.Where(filter);
            }
            return query;
        }

        public virtual async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>>? filter = null, bool isTracked = false)
        {
            IQueryable<TEntity> query = isTracked ? _dbSet : _dbSet.AsNoTracking();
            if (filter is not null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public virtual async Task InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }
        

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    
}