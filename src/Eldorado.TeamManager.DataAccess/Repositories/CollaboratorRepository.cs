using Eldorado.TeamManager.DataAccess.Base;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;

namespace Eldorado.TeamManager.DataAccess.Repositories
{
    public class CollaboratorRepository : CrudRepository<Collaborator>, ICollaboratorRepository
    {
        public CollaboratorRepository(TeamManagerDbContext dbContext) : base(dbContext)
        {
        }
    }
}