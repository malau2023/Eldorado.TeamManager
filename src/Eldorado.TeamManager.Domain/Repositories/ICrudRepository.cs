using Eldorado.TeamManager.Domain.Entities;

namespace Eldorado.TeamManager.Domain.Repositories
{
    public interface ICrudRepository<T> where T : BaseEntity
    {
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task Delete(T entity);
        Task<T> GetById(int id);
        IQueryable<T> GetAll();
    }
}
