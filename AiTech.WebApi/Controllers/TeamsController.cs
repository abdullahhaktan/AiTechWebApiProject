using AiTech.Businness.Services.TeamServices;
using AiTech.DTO.TeamDtos;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController(ITeamService _teamService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var teams = await _teamService.TGetAllAsync();
            return Ok(teams);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var team = await _teamService.TGetByIdAsync(id);
            return Ok(team);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTeamDto teamDto)
        {
            await _teamService.TCreateAsync(teamDto);
            return Ok("Kategori oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTeamDto teamDto)
        {
            await _teamService.TUpdateAsync(teamDto);
            return Ok("Hakkımda güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _teamService.TDeleteAsync(id);
            return Ok("Hakkımda silindi");
        }
    }
}
