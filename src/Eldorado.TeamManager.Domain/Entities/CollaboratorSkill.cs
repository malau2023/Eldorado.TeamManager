namespace Eldorado.TeamManager.Domain.Entities
{
    public class CollaboratorSkill : BaseEntity
    {
        public CollaboratorSkill(long codCollaborator, long codSkill)
        {
            CodCollaborator = codCollaborator;
            CodSkill = codSkill;
        }
        public long CodCollaborator { get; set; }
        public virtual Collaborator Collaborator { get; set; }
        public long CodSkill { get; set; }
        public virtual Skill Skill { get; set; }
    }
}