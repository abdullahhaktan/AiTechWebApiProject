using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.AboutItemDtos;

namespace AiTech.Businness.Services.AboutItemServices
{
    public interface IAboutItemService : IGenericService<ResultAboutItemDto, CreateAboutItemDto, UpdateAboutItemDto>
    {
    }
}
