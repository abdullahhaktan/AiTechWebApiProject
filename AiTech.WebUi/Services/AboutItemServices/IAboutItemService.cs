using AiTech.WebUi.DTOs.AboutItemDtos;

namespace AiTech.WebUi.Services.AboutItemServices
{
    public interface IAboutItemService
    {
        Task<List<ResultAboutItemDto>> GetAllAsync();
        Task<UpdateAboutItemDto> GetByIdAsync(int id);
        Task CreateAsync(CreateAboutItemDto dto);
        Task UpdateAsync(UpdateAboutItemDto dto);
        Task DeleteAsync(int id);
    }
}
