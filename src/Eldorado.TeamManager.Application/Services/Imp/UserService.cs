using AutoMapper;
using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;

namespace Eldorado.TeamManager.Application.Services.Imp
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public IEnumerable<UserDto> ListAll()
        {
            var users = _userRepository.GetAll();
            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task Create(UserDto dto)
        {
            var user =  new User(dto.FirsName, dto.LastName, dto.Email, dto.Password, dto.Type, dto.Active);
            await _userRepository.Create(user);
        }

        public async Task Update(UserDto dto)
        {
            var user = _userRepository.GetById(dto.Id).Result;
            user.Edit(dto.FirsName, dto.LastName, dto.Email, dto.Password, dto.Type, dto.Active);

            await _userRepository.Update(user);
        }

        public async Task<UserDto> GetById(int id)
        {
            var user = await _userRepository.GetById(id);
            
            return _mapper.Map<UserDto>(user);
        }

        public async Task Delete(int id)
        {
            await _userRepository.Delete(id);
        }
    }
}
