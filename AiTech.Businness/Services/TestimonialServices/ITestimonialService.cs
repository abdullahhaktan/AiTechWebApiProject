using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.TestimonailDtos;

namespace AiTech.Businness.Services.TestimonialServices
{
    public interface ITestimonialService : IGenericService<ResultTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
    {
    }
}
