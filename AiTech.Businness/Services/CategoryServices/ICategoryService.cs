using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.CategoryDtos;

namespace AiTech.Businness.Services.CategoryServices
{
    public interface ICategoryService : IGenericService<ResultCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
    }
}
