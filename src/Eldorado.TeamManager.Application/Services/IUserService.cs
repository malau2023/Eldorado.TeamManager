using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Application.Services
{
    public interface IUserService
    {
        Task Create(UserDto dto);
        Task Update(UserDto dto);
        Task Delete(int id);
        IEnumerable<UserDto> ListAll();
        Task<UserDto> GetById(int id);
    }
}
