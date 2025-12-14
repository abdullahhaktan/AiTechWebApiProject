using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.SocialDtos;
using AiTech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.Businness.Services.SocialServices
{
    public interface ISocialService : IGenericService<ResultSocialDto,CreateSocialDto,UpdateSocialDto>
    {
    }
}
