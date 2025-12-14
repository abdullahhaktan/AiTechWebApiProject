using AiTech.WebUi.DTOs.BannerDtos;

namespace AiTech.WebUi.Services.BannerServices
{
    public interface IBannerService
    {
        Task MakeActiveAsync(int id);
        Task MakePasiveAsync(int id);
        Task<List<ResultBannerDto>> GetAllAsync();
        Task<UpdateBannerDto> GetByIdAsync(int id);
        Task CreateAsync(CreateBannerDto dto);
        Task UpdateAsync(UpdateBannerDto dto);
        Task DeleteAsync(int id);
    }
}
