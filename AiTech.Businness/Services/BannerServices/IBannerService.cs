using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.BannerDtos;

namespace AiTech.Businness.Services.BannerServices
{
    public interface IBannerService:IGenericService<ResultBannerDto,CreateBannerDto,UpdateBannerDto>
    {
        Task TMakeActiveAsync(int id);
        Task TMakePasiveAsync(int id);
    }
}
