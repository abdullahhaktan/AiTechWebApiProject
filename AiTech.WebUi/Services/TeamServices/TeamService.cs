using AiTech.WebUi.DTOs.TeamDtos;

namespace AiTech.WebUi.Services.TeamServices
{
    public class TeamService : ITeamService
    {
        private readonly HttpClient _client;

        public TeamService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7187/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateTeamDto dto)
        {
            await _client.PostAsJsonAsync("teams", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("teams/" + id);
        }

        public async Task<List<ResultTeamDto>> GetAllAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultTeamDto>>("teams/");
            if (values == null)
            {
                return new List<ResultTeamDto>(values);
            }

            return values;
        }

        public async Task<UpdateTeamDto> GetByIdAsync(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateTeamDto>("teams/" + id);
            if (value == null)
            {
                return new UpdateTeamDto();
            }
            return value;
        }

        public async Task UpdateAsync(UpdateTeamDto dto)
        {
            await _client.PutAsJsonAsync("teams", dto);
        }
    }
}
