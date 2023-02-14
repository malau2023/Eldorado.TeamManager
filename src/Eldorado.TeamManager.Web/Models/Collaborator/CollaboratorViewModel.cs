using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Web.Models.Collaborator
{
    public class CollaboratorViewModel
    {
        public CollaboratorViewModel()
        {
            Skills = new List<SkillDto>();
            Collaborator = new CollaboratorDto();
        }
        public CollaboratorDto Collaborator { get; set; }

        public List<SkillDto> Skills { get; set; }
    }
}