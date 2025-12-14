using AiTech.Businness.Services.FAQServices;
using AiTech.DTO.FAQDtos;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQsController(IFaqService _faqService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var faqs = await _faqService.TGetAllAsync();
            return Ok(faqs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var faq = await _faqService.TGetByIdAsync(id);
            return Ok(faq);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFaqDto faqDto)
        {
            await _faqService.TCreateAsync(faqDto);
            return Ok("Kategori oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFaqDto faqDto)
        {
            await _faqService.TUpdateAsync(faqDto);
            return Ok("Hakkımda güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _faqService.TDeleteAsync(id);
            return Ok("Hakkımda silindi");
        }
    }
}
