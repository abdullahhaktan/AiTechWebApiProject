using AiTech.WebUi.DTOs.TestimonialDtos;

namespace AiTech.WebUi.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllAsync();
        Task<UpdateTestimonialDto> GetByIdAsync(int id);
        Task CreateAsync(CreateTestimonialDto dto);
        Task UpdateAsync(UpdateTestimonialDto dto);
        Task DeleteAsync(int id);
    }
}
