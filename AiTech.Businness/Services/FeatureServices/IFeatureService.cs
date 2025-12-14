

using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.FeatureDtos;

namespace AiTech.Businness.Services.FeatureServices
{
    public interface IFeatureService : IGenericService<ResultFeatureDto,CreateFeatureDto,UpdateFeatureDto>
    {
    }
}
