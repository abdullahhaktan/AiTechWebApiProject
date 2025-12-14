using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.FAQDtos;

namespace AiTech.Businness.Services.FAQServices
{
    public interface IFaqService : IGenericService<ResultFaqDto,CreateFaqDto,UpdateFaqDto>
    {
    }
}
