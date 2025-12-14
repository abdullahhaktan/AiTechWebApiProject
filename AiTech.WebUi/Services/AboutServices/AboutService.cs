using AiTech.WebUi.DTOs.AboutDtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using System.Text;

namespace AiTech.WebUi.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly HttpClient _client;

        public AboutService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7187/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutDto dto)
        {
            await _client.PostAsJsonAsync("abouts", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("abouts/" + id);
        }

        public async Task<List<ResultAboutDto>> GetAllAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultAboutDto>>("abouts/");
            if (values == null)
            {
                return new List<ResultAboutDto>(values);
            }

            return values;
        }

        public async Task<UpdateAboutDto> GetByIdAsync(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateAboutDto>("abouts/" + id);
            if(value == null)
            {
                return new UpdateAboutDto();
            }
            return value;
        }

        public async Task UpdateAsync(UpdateAboutDto dto)
        {
            await _client.PutAsJsonAsync("abouts", dto);
        }
    }
}
