using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.Businness.Services.GenericServices
{
    public interface IGenericService<TResultDto,TCreateDto,TUpdateDto>
    {
        Task<List<TResultDto>> TGetAllAsync();
        Task<TResultDto> TGetByIdAsync(int id);
        Task TCreateAsync(TCreateDto createdDto);
        Task TUpdateAsync(TUpdateDto updateDto);
        Task TDeleteAsync(int id);
    }
}
