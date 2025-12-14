using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.DTO.AboutDtos
{
    public record GetAboutByIdDto(int Id, string Title, string? ImageUrl, string Description);
}
