using Eldorado.TeamManager.Domain.Enums;

namespace Eldorado.TeamManager.Domain.Entities
{
    public class Skill : BaseEntity
    {
        public Skill() { }

        public Skill(string name, string description, SkillType type)
        {
            Name = name;
            Description = description;
            Type = type;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public SkillType Type { get; private set; }

        public void Edit(string name, string description, SkillType type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }
}