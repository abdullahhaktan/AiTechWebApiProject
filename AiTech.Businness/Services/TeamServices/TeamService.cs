using AiTech.DataAccess.Repositories.TeamRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.TeamDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Businness.Services.TeamServices
{
    public class TeamService(ITeamRepository _teamRepository, IUnitOfWork _unitOfWork) : ITeamService
    {
        public async Task TCreateAsync(CreateTeamDto createdDto)
        {
            var team = createdDto.Adapt<Team>();
            await _teamRepository.CreateAsync(team);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var team = await _teamRepository.GetByIdAsync(id);
            _teamRepository.Delete(team);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultTeamDto>> TGetAllAsync()
        {
            var teams = await _teamRepository.GetAllAsync();
            return teams.Adapt<List<ResultTeamDto>>();
        }

        public async Task<ResultTeamDto> TGetByIdAsync(int id)
        {
            var team = await _teamRepository.GetByIdAsync(id);
            return team.Adapt<ResultTeamDto>();
        }

        public Task TUpdateAsync(UpdateTeamDto updateDto)
        {
            var team = updateDto.Adapt<Team>();
            _teamRepository.Update(team);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
