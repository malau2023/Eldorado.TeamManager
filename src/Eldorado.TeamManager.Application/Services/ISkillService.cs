using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Application.Services
{
    public interface ISkillService
    {
        Task Create(SkillDto dto);
        Task Update(SkillDto dto);
        Task Delete(int id);
        IEnumerable<SkillDto> ListAll();
        Task<SkillDto> GetById(int id);
    }
}
