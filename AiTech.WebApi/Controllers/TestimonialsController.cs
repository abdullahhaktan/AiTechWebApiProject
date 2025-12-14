using AiTech.Businness.Services.TestimonialServices;
using AiTech.DTO.TestimonailDtos;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(ITestimonialService _testimonialService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var testimonials = await _testimonialService.TGetAllAsync();
            return Ok(testimonials);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var testimonial = await _testimonialService.TGetByIdAsync(id);
            return Ok(testimonial);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialDto testimonialDto)
        {
            await _testimonialService.TCreateAsync(testimonialDto);
            return Ok("Kategori oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTestimonialDto testimonialDto)
        {
            await _testimonialService.TUpdateAsync(testimonialDto);
            return Ok("Hakkımda güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _testimonialService.TDeleteAsync(id);
            return Ok("Hakkımda silindi");
        }
    }
}
