using AiTech.WebUi.DTOs.AboutItemDtos;
using AiTech.WebUi.Services.AboutItemServices;

namespace AiTech.WebUi.Services.AboutItemItemServices
{
    public class AboutItemService : IAboutItemService
    {
        private readonly HttpClient _client;

        public AboutItemService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7187/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutItemDto dto)
        {
            await _client.PostAsJsonAsync("aboutItems", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("aboutItems/" + id);
        }

        public async Task<List<ResultAboutItemDto>> GetAllAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultAboutItemDto>>("aboutItems/");
            if (values == null)
            {
                return new List<ResultAboutItemDto>(values);
            }

            return values;
        }

        public async Task<UpdateAboutItemDto> GetByIdAsync(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateAboutItemDto>("aboutItems/" + id);
            if (value == null)
            {
                return new UpdateAboutItemDto();
            }
            return value;
        }

        public async Task UpdateAsync(UpdateAboutItemDto dto)
        {
            await _client.PutAsJsonAsync("aboutItems", dto);
        }
    }
}
