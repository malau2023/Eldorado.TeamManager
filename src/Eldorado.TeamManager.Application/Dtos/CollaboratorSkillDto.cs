namespace Eldorado.TeamManager.Application.Dtos
{
    public class CollaboratorSkillDto
    {
        public int Id { get; set; }
        public long CodCollaborator { get; set; }
        public long CodSkill { get; set; }
        public SkillDto Skill { get; set; }

    }

}

