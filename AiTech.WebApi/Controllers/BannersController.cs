using AiTech.Businness.Services.BannerServices;
using AiTech.DTO.BannerDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BannersController(IBannerService _bannerService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _bannerService.TGetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var banner = await _bannerService.TGetByIdAsync(id);
            return Ok(banner);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto bannerDto)
        {
            await _bannerService.TCreateAsync(bannerDto);
            return Ok("Kategori oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBannerDto bannerDto)
        {
            await _bannerService.TUpdateAsync(bannerDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bannerService.TDeleteAsync(id);
            return NoContent();
        }

        [HttpPatch("makeActive/{id}")]
        public async Task<IActionResult> MakeActive(int id)
        {
            await _bannerService.TMakeActiveAsync(id);
            return NoContent();
        }

        [HttpPatch("makePassive/{id}")]
        public async Task<IActionResult> MakePassive(int id)
        {
            await _bannerService.TMakePasiveAsync(id);
            return NoContent();
        }
    }
}
