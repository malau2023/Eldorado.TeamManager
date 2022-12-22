using Eldorado.TeamManager.Domain.Entities;

namespace Eldorado.TeamManager.Domain.Repositories
{
    public interface IUserRepository : ICrudRepository<User>
    {
        User GetByEmailAndPassword(string email, string password);
    }
}
