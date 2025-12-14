using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.TeamDtos;

namespace AiTech.Businness.Services.TeamServices
{
    public interface ITeamService : IGenericService<ResultTeamDto,CreateTeamDto,UpdateTeamDto>
    {
    }
}
