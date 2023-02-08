using AutoMapper;
using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;


namespace Eldorado.TeamManager.Application.Services.Imp
{
    public class CollaboratorService : ICollaboratorService
    {
        private readonly ICollaboratorRepository _collaboratorRepository;
        private readonly IMapper _mapper;

        public CollaboratorService(ICollaboratorRepository collaboratorRepository, IMapper mapper)
        {
            _collaboratorRepository = collaboratorRepository;
            _mapper = mapper;
        }

        public IEnumerable<CollaboratorDto> ListAll()
        {
            var collaborators = _collaboratorRepository.GetAll();

            return _mapper.Map<List<CollaboratorDto>>(collaborators);
        }

        public async Task Create(CollaboratorDto dto)
        {
            //var collaborator = new Collaborator(dto.Name, dto.BirthDate, dto.RG, dto.Email, dto.observation, dto.skill);
            //await _collaboratorRepository.Create(collaborator);
        }

        public async Task Update(CollaboratorDto dto)
        {
            var collaborator = _collaboratorRepository.GetById(dto.Id).Result;
           //collaborator.Edit(dto.Name, dto.BirthDate, dto.RG, dto.Email, dto.Observation, dto.Skill);

            await _collaboratorRepository.Update(collaborator);
        }

        public async Task<CollaboratorDto> GetById(int id)
        {
            var collaborator = await _collaboratorRepository.GetById(id);
            return _mapper.Map<CollaboratorDto>(collaborator);
        }

        public async Task Delete(int id)
        {
            await _collaboratorRepository.Delete(id);
        }
    }

}

