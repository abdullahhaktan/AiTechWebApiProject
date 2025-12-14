using AiTech.Businness.Services.ChooseServices;
using AiTech.DTO.ChooseDtos;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoosesController(IChooseService _chooseService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var chooses = await _chooseService.TGetAllAsync();
            return Ok(chooses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var choose = await _chooseService.TGetByIdAsync(id);
            return Ok(choose);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateChooseDto chooseDto)
        {
            await _chooseService.TCreateAsync(chooseDto);
            return Ok("Kategori oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateChooseDto chooseDto)
        {
            await _chooseService.TUpdateAsync(chooseDto);
            return Ok("Hakkımda güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _chooseService.TDeleteAsync(id);
            return Ok("Hakkımda silindi");
        }
    }
}
