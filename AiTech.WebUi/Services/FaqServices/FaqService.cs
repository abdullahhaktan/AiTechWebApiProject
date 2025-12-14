using AiTech.WebUi.DTOs.FaqDtos;

namespace AiTech.WebUi.Services.FaqServices
{
    public class FaqService : IFaqService
    {
        private readonly HttpClient _client;

        public FaqService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7187/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateFaqDto dto)
        {
            await _client.PostAsJsonAsync("faqs", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("faqs/" + id);
        }

        public async Task<List<ResultFaqDto>> GetAllAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultFaqDto>>("faqs/");
            if (values == null)
            {
                return new List<ResultFaqDto>(values);
            }

            return values;
        }

        public async Task<UpdateFaqDto> GetByIdAsync(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateFaqDto>("faqs/" + id);
            if (value == null)
            {
                return new UpdateFaqDto();
            }
            return value;
        }

        public async Task UpdateAsync(UpdateFaqDto dto)
        {
            await _client.PutAsJsonAsync("faqs", dto);
        }
    }
}
