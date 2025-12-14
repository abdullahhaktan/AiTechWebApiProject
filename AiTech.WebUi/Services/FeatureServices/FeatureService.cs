using AiTech.WebUi.DTOs.FeatureDtos;

namespace AiTech.WebUi.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly HttpClient _client;

        public FeatureService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7187/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateFeatureDto dto)
        {
            await _client.PostAsJsonAsync("features", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("features/" + id);
        }

        public async Task<List<ResultFeatureDto>> GetAllAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultFeatureDto>>("features/");
            if (values == null)
            {
                return new List<ResultFeatureDto>(values);
            }

            return values;
        }

        public async Task<UpdateFeatureDto> GetByIdAsync(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateFeatureDto>("features/" + id);
            if (value == null)
            {
                return new UpdateFeatureDto();
            }
            return value;
        }

        public async Task UpdateAsync(UpdateFeatureDto dto)
        {
            await _client.PutAsJsonAsync("features", dto);
        }
    }
}
