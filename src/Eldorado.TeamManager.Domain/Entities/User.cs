using Eldorado.TeamManager.Domain.Enums;

namespace Eldorado.TeamManager.Domain.Entities
{
    //Teste
    public class User : BaseEntity
    {
        public User() { }
        public User(string firsName, string lastName, string email, string password, UserType type, bool active)
        {
            FirsName = firsName;
            LastName = lastName;
            Email = email;
            Password = password;
            Type = type;
            Active = active;
        }

        public string FirsName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public UserType Type { get; private set; }
        public bool Active { get; private set; }

        public void Edit(string firsName, string lastName, string email, string password, UserType type, bool active)
        {
            FirsName = firsName;
            LastName = lastName;
            Email = email;
            
            if(!string.IsNullOrEmpty(password))
                Password = password ;

            Type = type;
            Active = active;
        }
    }
}
