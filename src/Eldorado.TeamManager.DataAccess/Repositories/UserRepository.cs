using Eldorado.TeamManager.DataAccess.Base;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;

namespace Eldorado.TeamManager.DataAccess.Repositories
{
    public class UserRepository : CrudRepository<User>, IUserRepository
    {
        public UserRepository(TeamManagerDbContext dbContext) : base(dbContext)
        {
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            return GetAll().FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}
