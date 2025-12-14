using AiTech.WebUi.DTOs.ChooseDtos;

namespace AiTech.WebUi.Services.ChooseServices
{
    public class ChooseService : IChooseService
    {
        private readonly HttpClient _client;

        public ChooseService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7187/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateChooseDto dto)
        {
            await _client.PostAsJsonAsync("chooses", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("chooses/" + id);
        }

        public async Task<List<ResultChooseDto>> GetAllAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultChooseDto>>("chooses/");
            if (values == null)
            {
                return new List<ResultChooseDto>(values);
            }
            return values;
        }

        public async Task<UpdateChooseDto> GetByIdAsync(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateChooseDto>("chooses/" + id);
            if (value == null)
            {
                return new UpdateChooseDto();
            }
            return value;
        }

        public async Task UpdateAsync(UpdateChooseDto dto)
        {
            await _client.PutAsJsonAsync("chooses", dto);
        }
    }
}
