using AiTech.WebUi.DTOs.TestimonialDtos;

namespace AiTech.WebUi.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly HttpClient _client;

        public TestimonialService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7187/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateTestimonialDto dto)
        {
            await _client.PostAsJsonAsync("testimonials", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("testimonials/" + id);
        }

        public async Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultTestimonialDto>>("testimonials/");
            if (values == null)
            {
                return new List<ResultTestimonialDto>(values);
            }

            return values;
        }

        public async Task<UpdateTestimonialDto> GetByIdAsync(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateTestimonialDto>("testimonials/" + id);
            if (value == null)
            {
                return new UpdateTestimonialDto();
            }
            return value;
        }

        public async Task UpdateAsync(UpdateTestimonialDto dto)
        {
            await _client.PutAsJsonAsync("testimonials", dto);
        }
    }
}
