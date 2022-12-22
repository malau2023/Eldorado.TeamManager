using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Web.Models.User
{
    public class UserListViewModel
    {
        public UserListViewModel()
        {
            Users = new List<UserDto>();
        }

        public IEnumerable<UserDto> Users { get; set; }
    }
}
