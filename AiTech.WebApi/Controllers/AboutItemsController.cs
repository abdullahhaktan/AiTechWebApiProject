using AiTech.Businness.Services.AboutItemServices;
using AiTech.DTO.AboutItemDtos;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutItemsController(IAboutItemService _aboutItemService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var aboutItems = await _aboutItemService.TGetAllAsync();
            return Ok(aboutItems);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var aboutItem = await _aboutItemService.TGetByIdAsync(id);
            return Ok(aboutItem);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutItemDto aboutItemDto)
        {
            await _aboutItemService.TCreateAsync(aboutItemDto);
            return Ok("Kategori oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutItemDto aboutItemDto)
        {
            await _aboutItemService.TUpdateAsync(aboutItemDto);
            return Ok("Kategori güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aboutItemService.TDeleteAsync(id);
            return Ok("Kategori silindi");
        }
    }
}
