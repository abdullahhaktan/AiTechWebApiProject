using AiTech.Businness.Services.AboutItemServices;
using AiTech.DataAccess.Repositories.AboutItemRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.AboutDtos;
using AiTech.DTO.AboutItemDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Businness.Services.AboutItemItemItemServices
{
    public class AboutItemService(IAboutItemRepository _aboutItemRepository, IUnitOfWork _unitOfWork) : IAboutItemService
    {
        public async Task TCreateAsync(CreateAboutItemDto createdDto)
        {
            var aboutItem = createdDto.Adapt<AboutItem>();
            await _aboutItemRepository.CreateAsync(aboutItem);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var aboutItem = await _aboutItemRepository.GetByIdAsync(id);
            _aboutItemRepository.Delete(aboutItem);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultAboutItemDto>> TGetAllAsync()
        {
            var aboutItems = await _aboutItemRepository.GetAllAsync();
            return aboutItems.Adapt<List<ResultAboutItemDto>>();
        }

        public async Task<ResultAboutItemDto> TGetByIdAsync(int id)
        {
            var aboutItem = await _aboutItemRepository.GetByIdAsync(id);
            return aboutItem.Adapt<ResultAboutItemDto>();
        }

        public Task TUpdateAsync(UpdateAboutItemDto updateDto)
        {
            var aboutItem = updateDto.Adapt<AboutItem>();
            _aboutItemRepository.Update(aboutItem);
            return _unitOfWork.SaveChangesAsync();
        }

    }
}
