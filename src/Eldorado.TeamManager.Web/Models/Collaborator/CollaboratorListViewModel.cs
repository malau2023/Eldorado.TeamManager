using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Web.Models.Collaborator
{
    public class CollaboratorListViewModel
    {
        public CollaboratorListViewModel()
        {
            Collaborators = new List<CollaboratorDto>();
        }
        
        public IEnumerable<CollaboratorDto> Collaborators { get; set; }
    }
}