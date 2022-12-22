using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Eldorado.TeamManager.DataAccess.Base
{
    public class CrudRepository<T> : ICrudRepository<T> where T : BaseEntity
    {
        protected readonly TeamManagerDbContext _dbContext;

        public CrudRepository(TeamManagerDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            await Delete(entity);
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public async Task Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
