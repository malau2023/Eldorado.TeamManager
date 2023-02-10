using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Web.Models.Skill
{
    public class SkillListViewModel
    {
        public SkillListViewModel()
        {
            Skills = new List<SkillDto>();
        }

        public IEnumerable<SkillDto> Skills { get; set; }
    }
}
