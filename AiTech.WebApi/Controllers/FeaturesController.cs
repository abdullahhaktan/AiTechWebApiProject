using AiTech.Businness.Services.FeatureServices;
using AiTech.DTO.FeatureDtos;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController(IFeatureService _featureService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var features = await _featureService.TGetAllAsync();
            return Ok(features);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var feature = await _featureService.TGetByIdAsync(id);
            return Ok(feature);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFeatureDto featureDto)
        {
            await _featureService.TCreateAsync(featureDto);
            return Ok("Servis oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFeatureDto featureDto)
        {
            await _featureService.TUpdateAsync(featureDto);
            return Ok("Servis güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _featureService.TDeleteAsync(id);
            return Ok("Servis silindi");
        }
    }
}
