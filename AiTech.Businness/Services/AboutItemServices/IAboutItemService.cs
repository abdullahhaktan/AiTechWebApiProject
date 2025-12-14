using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.AboutDtos;
using AiTech.DTO.AboutItemDtos;
using AiTech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.Businness.Services.AboutItemServices
{
    public interface IAboutItemService : IGenericService<ResultAboutItemDto,CreateAboutItemDto,UpdateAboutItemDto>
    {
    }
}
