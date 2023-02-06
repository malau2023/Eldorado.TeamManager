using AutoMapper;
using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;


namespace Eldorado.TeamManager.Application.Services.Imp
{

    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;

        private readonly IMapper _mapper;

        public SkillService(ISkillRepository skillRepository, IMapper mapper)
        {
            _skillRepository = skillRepository;
            _mapper = mapper;
        }

        public IEnumerable<SkillDto> ListAll()
        {
            var skills = _skillRepository.GetAll();
            return _mapper.Map<List<SkillDto>>(skills);
        }

        public async Task Create(SkillDto dto)
        {
            var skill = new Skill(dto.Name, dto.Description, dto.Type);
            await _skillRepository.Create(skill);

        }

        public async Task Update(SkillDto dto)
        {
            var skill = _skillRepository.GetById(dto.Id).Result;
            skill.Edit(dto.Name, dto.Description, dto.Type);

            await _skillRepository.Update(skill);
        }

        public async Task<SkillDto> GetById(int id)
        {
            var skill = await _skillRepository.GetById(id);
            return _mapper.Map<SkillDto>(skill);

        }

        public async Task Delete(int id)
        {
            await _skillRepository.Delete(id);

        }
    }




}

