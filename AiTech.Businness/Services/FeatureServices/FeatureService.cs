using AiTech.DataAccess.Repositories.FeatureRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.FeatureDtos;
using AiTech.Entity.Entities;
using Mapster;


namespace AiTech.Businness.Services.FeatureServices
{
    public class FeatureService(IFeatureRepository _featureRepository, IUnitOfWork _unitOfWork) : IFeatureService
    {
        public async Task TCreateAsync(CreateFeatureDto createdDto)
        {
            var feature = createdDto.Adapt<Feature>();
            await _featureRepository.CreateAsync(feature);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var feature = await _featureRepository.GetByIdAsync(id);
            _featureRepository.Delete(feature);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultFeatureDto>> TGetAllAsync()
        {
            var features = await _featureRepository.GetAllAsync();
            return features.Adapt<List<ResultFeatureDto>>();
        }

        public async Task<ResultFeatureDto> TGetByIdAsync(int id)
        {
            var feature = await _featureRepository.GetByIdAsync(id);
            return feature.Adapt<ResultFeatureDto>();
        }

        public Task TUpdateAsync(UpdateFeatureDto updateDto)
        {
            var feature = updateDto.Adapt<Feature>();
            _featureRepository.Update(feature);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}