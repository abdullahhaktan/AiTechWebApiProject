using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.ContactDtos;

namespace AiTech.Businness.Services.ContactServices
{
    public interface IContactService:IGenericService<ResultContactDto,CreateContactDto,UpdateContactDto>
    {
    }
}
