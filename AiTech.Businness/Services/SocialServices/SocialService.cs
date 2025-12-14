using AiTech.DataAccess.Repositories.SocialRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.SocialDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Businness.Services.SocialServices
{
    public class SocialService(ISocialRepository _socialRepository, IUnitOfWork _unitOfWork) : ISocialService
    {
        public async Task TCreateAsync(CreateSocialDto createdDto)
        {
            var social = createdDto.Adapt<Social>();
            await _socialRepository.CreateAsync(social);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var social = await _socialRepository.GetByIdAsync(id);
            _socialRepository.Delete(social);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultSocialDto>> TGetAllAsync()
        {
            var socials = await _socialRepository.GetAllAsync();
            return socials.Adapt<List<ResultSocialDto>>();
        }

        public async Task<ResultSocialDto> TGetByIdAsync(int id)
        {
            var social = await _socialRepository.GetByIdAsync(id);
            return social.Adapt<ResultSocialDto>();
        }

        public Task TUpdateAsync(UpdateSocialDto updateDto)
        {
            var social = updateDto.Adapt<Social>();
            _socialRepository.Update(social);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
