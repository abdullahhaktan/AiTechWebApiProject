using AiTech.WebUi.DTOs.SocialDtos;

namespace AiTech.WebUi.Services.SocialServices
{
    public interface ISocialService
    {
        Task<List<ResultSocialDto>> GetAllAsync();
        Task<UpdateSocialDto> GetByIdAsync(int id);
        Task CreateAsync(CreateSocialDto dto);
        Task UpdateAsync(UpdateSocialDto dto);
        Task DeleteAsync(int id);
    }
}
