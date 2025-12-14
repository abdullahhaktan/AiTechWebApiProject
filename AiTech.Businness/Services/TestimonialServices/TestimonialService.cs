using AiTech.Businness.Services.GenericServices;
using AiTech.DataAccess.Repositories.TestimonialRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.TestimonailDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Businness.Services.TestimonialServices
{
    public class TestimonialService(ITestimonailRepository _testimonialRepository, IUnitOfWork _unitOfWork) : ITestimonialService
    {
        public async Task TCreateAsync(CreateTestimonialDto createdDto)
        {
            var testimonial = createdDto.Adapt<Testimonial>();
            await _testimonialRepository.CreateAsync(testimonial);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var testimonial = await _testimonialRepository.GetByIdAsync(id);
            _testimonialRepository.Delete(testimonial);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultTestimonialDto>> TGetAllAsync()
        {
            var testimonials = await _testimonialRepository.GetAllAsync();
            return testimonials.Adapt<List<ResultTestimonialDto>>();
        }

        public async Task<ResultTestimonialDto> TGetByIdAsync(int id)
        {
            var testimonial = await _testimonialRepository.GetByIdAsync(id);
            return testimonial.Adapt<ResultTestimonialDto>();
        }

        public Task TUpdateAsync(UpdateTestimonialDto updateDto)
        {
            var testimonial = updateDto.Adapt<Testimonial>();
            _testimonialRepository.Update(testimonial);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
