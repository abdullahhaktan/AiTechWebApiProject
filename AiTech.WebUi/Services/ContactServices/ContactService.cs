using AiTech.WebUi.DTOs.ContactDtos;

namespace AiTech.WebUi.Services.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly HttpClient _client;

        public ContactService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7187/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateContactDto dto)
        {
            await _client.PostAsJsonAsync("contacts", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("contacts/" + id);
        }

        public async Task<List<ResultContactDto>> GetAllAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultContactDto>>("contacts/");
            if (values == null)
            {
                return new List<ResultContactDto>(values);
            }

            return values;
        }

        public async Task<UpdateContactDto> GetByIdAsync(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateContactDto>("contacts/" + id);
            if (value == null)
            {
                return new UpdateContactDto();
            }
            return value;
        }

        public async Task UpdateAsync(UpdateContactDto dto)
        {
            await _client.PutAsJsonAsync("contacts", dto);
        }
    }
}
