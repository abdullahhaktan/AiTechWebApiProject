using AiTech.WebUi.DTOs.ContactDtos;

namespace AiTech.WebUi.Services.ContactServices
{
    public interface IContactService
    {
        Task<List<ResultContactDto>> GetAllAsync();
        Task<UpdateContactDto> GetByIdAsync(int id);
        Task CreateAsync(CreateContactDto dto);
        Task UpdateAsync(UpdateContactDto dto);
        Task DeleteAsync(int id);
    }
}
