using Eldorado.TeamManager.Domain.Enums;

namespace Eldorado.TeamManager.Application.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public bool Active { get; set; }

    }
}
