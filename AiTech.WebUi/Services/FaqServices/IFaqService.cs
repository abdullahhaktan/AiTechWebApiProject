using AiTech.WebUi.DTOs.FaqDtos;

namespace AiTech.WebUi.Services.FaqServices
{
    public interface IFaqService
    {
        Task<List<ResultFaqDto>> GetAllAsync();
        Task<UpdateFaqDto> GetByIdAsync(int id);
        Task CreateAsync(CreateFaqDto dto);
        Task UpdateAsync(UpdateFaqDto dto);
        Task DeleteAsync(int id);
    }
}
