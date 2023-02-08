using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Application.Services
{
    public interface ICollaboratorService
    {
        Task Create(CollaboratorDto dto);
        Task Update(CollaboratorDto dto);
        Task Delete(int id);
        IEnumerable<CollaboratorDto> ListAll();
        Task<CollaboratorDto> GetById(int id);
    }
}


