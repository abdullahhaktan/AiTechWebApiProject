using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.TestimonailDtos;
using AiTech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.Businness.Services.TestimonialServices
{
    public interface ITestimonialService:IGenericService<ResultTestimonialDto,CreateTestimonialDto,UpdateTestimonialDto>
    {
    }
}
