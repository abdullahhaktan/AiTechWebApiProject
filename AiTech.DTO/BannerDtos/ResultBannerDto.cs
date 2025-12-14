using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.DTO.BannerDtos
{
    public record ResultBannerDto(int Id,string Title,string Description,string? Image,bool IsActive);
}
