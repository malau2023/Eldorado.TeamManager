using Eldorado.TeamManager.DataAccess.Base;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;

namespace Eldorado.TeamManager.DataAccess.Repositories
{
    public class SkillRepository : CrudRepository<Skill>, ISkillRepository
    {
        public SkillRepository(TeamManagerDbContext dbContext) : base(dbContext)
        {
        }
    }
}
