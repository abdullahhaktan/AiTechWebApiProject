using AiTech.WebUi.DTOs.FeatureDtos;

namespace AiTech.WebUi.Services.FeatureServices
{
    public interface IFeatureService
    {
        Task<List<ResultFeatureDto>> GetAllAsync();
        Task<UpdateFeatureDto> GetByIdAsync(int id);
        Task CreateAsync(CreateFeatureDto dto);
        Task UpdateAsync(UpdateFeatureDto dto);
        Task DeleteAsync(int id);
    }
}
