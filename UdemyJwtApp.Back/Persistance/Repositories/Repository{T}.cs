using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Persistance.Context;

namespace UdemyJwtApp.Back.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly UdemyJwtContext udemyJwtContext;

        public Repository(UdemyJwtContext udemyJwtContext)
        {
            this.udemyJwtContext = udemyJwtContext;
        }

        public async Task CreateAsync(T entity)
        {
            this.udemyJwtContext.Set<T>().Add(entity);
            await this.udemyJwtContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await this.udemyJwtContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await this.udemyJwtContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await this.udemyJwtContext.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsyc(T entity)
        {
            this.udemyJwtContext.Remove(entity);
            await this.udemyJwtContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            this.udemyJwtContext.Update(entity);
            await this.udemyJwtContext.SaveChangesAsync();
        }
    }
}
