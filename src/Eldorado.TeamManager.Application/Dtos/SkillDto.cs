using Eldorado.TeamManager.Domain.Enums;

namespace Eldorado.TeamManager.Application.Dtos
{
    public class SkillDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SkillType Type { get; set; }


    }
}
