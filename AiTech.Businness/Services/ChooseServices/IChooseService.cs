using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.ChooseDtos;
using AiTech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.Businness.Services.ChooseServices
{
    public interface IChooseService:IGenericService<ResultChooseDto,CreateChooseDto,UpdateChooseDto>
    {
    }
}
