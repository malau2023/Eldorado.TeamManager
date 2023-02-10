namespace Eldorado.TeamManager.Domain.Entities
{

    public class Collaborator : BaseEntity
    {
        public Collaborator() { }

        public Collaborator(string name, string rg, DateTime birthDate, string email, string observation, List<CollaboratorSkill> collaboratorSkills)
        {
            Name = name;
            RG = rg;
            BirthDate = birthDate;
            Email = email;
            Observation = observation;
            CollaboratorSkills = collaboratorSkills;
        }

        public string Name { get; set; }
        public string RG { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Observation { get; set; }
        public virtual List<CollaboratorSkill> CollaboratorSkills { get; set; }

        public void Edit(string name, string rg, DateTime birthDate, string email, string observation, List<CollaboratorSkill> collaboratorSkills)
        {
            Name = name;
            RG = rg;
            BirthDate = birthDate;
            Email = email;
            Observation = observation;
            CollaboratorSkills = collaboratorSkills;
        }
    }
}