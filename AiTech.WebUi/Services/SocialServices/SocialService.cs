using AiTech.WebUi.DTOs.SocialDtos;

namespace AiTech.WebUi.Services.SocialServices
{

    public class SocialService : ISocialService
    {
        private readonly HttpClient _client;

        public SocialService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7187/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateSocialDto dto)
        {
            await _client.PostAsJsonAsync("socials", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("socials/" + id);
        }

        public async Task<List<ResultSocialDto>> GetAllAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultSocialDto>>("socials/");
            if (values == null)
            {
                return new List<ResultSocialDto>(values);
            }

            return values;
        }

        public async Task<UpdateSocialDto> GetByIdAsync(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateSocialDto>("socials/" + id);
            if (value == null)
            {
                return new UpdateSocialDto();
            }
            return value;
        }

        public async Task UpdateAsync(UpdateSocialDto dto)
        {
            await _client.PutAsJsonAsync("socials", dto);
        }
    }
}