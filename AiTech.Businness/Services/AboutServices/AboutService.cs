using AiTech.DataAccess.Repositories.AboutRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.AboutDtos;
using AiTech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.Businness.Services.AboutServices
{
    public class AboutService(IAboutRepository _aboutRepository, IUnitOfWork _unitOfWork) : IAboutService
    {
        public async Task TCreateAsync(CreateAboutDto createdDto)
        {
            var about = createdDto.Adapt<About>();
            await _aboutRepository.CreateAsync(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var about = await _aboutRepository.GetByIdAsync(id);
            _aboutRepository.Delete(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultAboutDto>> TGetAllAsync()
        {
            var abouts = await _aboutRepository.GetAllAsync();
            return abouts.Adapt<List<ResultAboutDto>>();
        }

        public async Task<ResultAboutDto> TGetByIdAsync(int id)
        {
            var about = await _aboutRepository.GetByIdAsync(id);
            return about.Adapt<ResultAboutDto>();
        }

        public Task TUpdateAsync(UpdateAboutDto updateDto)
        {
            var about = updateDto.Adapt<About>();
            _aboutRepository.Update(about);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
