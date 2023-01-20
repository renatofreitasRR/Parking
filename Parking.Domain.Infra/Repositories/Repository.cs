using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Parking.Domain.Repositories.Contracts;
using Parking.Infra.Write.Data;

namespace Parking.Infra.Write.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal DbSet<T> DbSet;
        public Repository(DataContext context)
        {
            DbSet = context.Set<T>();
        }

        public virtual async Task<T> GetAsync(Guid id)
        {
            var entity = await DbSet.FindAsync(id);

            return entity;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await DbSet
                .Where(predicate)
                .ToListAsync();
        }

        public virtual async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            var entity = await DbSet.FindAsync(id);

            if (entity != null)
                DbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await DbSet
                .Where(predicate)
                .ToListAsync();
        }

        public virtual void Update(T entity)
        {
            DbSet.Update(entity);
        }
    }
}
