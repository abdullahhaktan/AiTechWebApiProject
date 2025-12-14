using AiTech.DataAccess.Repositories.ContactRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.ContactDtos;
using AiTech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.Businness.Services.ContactServices
{
    public class ContactService(IContactRepository _aboutRepository, IUnitOfWork _unitOfWork) : IContactService
    {
        public async Task TCreateAsync(CreateContactDto createdDto)
        {
            var about = createdDto.Adapt<Contact>();
            await _aboutRepository.CreateAsync(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var about = await _aboutRepository.GetByIdAsync(id);
            _aboutRepository.Delete(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultContactDto>> TGetAllAsync()
        {
            var abouts = await _aboutRepository.GetAllAsync();
            return abouts.Adapt<List<ResultContactDto>>();
        }

        public async Task<ResultContactDto> TGetByIdAsync(int id)
        {
            var about = await _aboutRepository.GetByIdAsync(id);
            return about.Adapt<ResultContactDto>();
        }

        public Task TUpdateAsync(UpdateContactDto updateDto)
        {
            var about = updateDto.Adapt<Contact>();
            _aboutRepository.Update(about);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
