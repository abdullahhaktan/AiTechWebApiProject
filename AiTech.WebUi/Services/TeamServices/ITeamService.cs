using AiTech.WebUi.DTOs.TeamDtos;

namespace AiTech.WebUi.Services.TeamServices
{
    public interface ITeamService
    {
        Task<List<ResultTeamDto>> GetAllAsync();
        Task<UpdateTeamDto> GetByIdAsync(int id);
        Task CreateAsync(CreateTeamDto dto);
        Task UpdateAsync(UpdateTeamDto dto);
        Task DeleteAsync(int id);
    }
}
