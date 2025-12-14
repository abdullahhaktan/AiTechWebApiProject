using AiTech.DataAccess.Repositories.BannerRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.BannerDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Businness.Services.BannerServices
{
    public class BannerService(IBannerRepository _bannerRepository , IUnitOfWork _unitOfWork) : IBannerService
    {
        public async Task TCreateAsync(CreateBannerDto createdDto)
        {
            var banner = createdDto.Adapt<Banner>();
            await _bannerRepository.CreateAsync(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            _bannerRepository.Delete(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultBannerDto>> TGetAllAsync()
        {
            var banners = await _bannerRepository.GetAllAsync();
            return banners.Adapt<List<ResultBannerDto>>();
        }

        public async Task<ResultBannerDto> TGetByIdAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            return banner.Adapt<ResultBannerDto>();
        }

        public async Task TMakeActiveAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            _bannerRepository.MakeActiveAsync(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TMakePasiveAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            _bannerRepository.MakePasiveAsync(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public Task TUpdateAsync(UpdateBannerDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
