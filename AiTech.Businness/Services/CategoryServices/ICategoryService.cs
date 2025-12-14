using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.Businness.Services.CategoryServices
{
    public interface ICategoryService:IGenericService<ResultCategoryDto,CreateCategoryDto,UpdateCategoryDto>
    {
    }
}
