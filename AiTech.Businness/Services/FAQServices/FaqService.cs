using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.FAQRepositories;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.FAQDtos;
using AiTech.Entity.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace AiTech.Businness.Services.FAQServices
{
    public class FaqService(IFaqRepository _faqRepository, IUnitOfWork _unitOfWork) : IFaqService
    {
        public async Task TCreateAsync(CreateFaqDto createdDto)
        {
            var faq = createdDto.Adapt<FAQ>();
            await _faqRepository.CreateAsync(faq);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var faq = await _faqRepository.GetByIdAsync(id);
            _faqRepository.Delete(faq);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultFaqDto>> TGetAllAsync()
        {
            var faqs = await _faqRepository.GetAllAsync();
            return faqs.Adapt<List<ResultFaqDto>>();
        }

        public async Task<ResultFaqDto> TGetByIdAsync(int id)
        {
            var faq = await _faqRepository.GetByIdAsync(id);
            return faq.Adapt<ResultFaqDto>();
        }

        public Task TUpdateAsync(UpdateFaqDto updateDto)
        {
            var faq = updateDto.Adapt<FAQ>();
            _faqRepository.Update(faq);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
