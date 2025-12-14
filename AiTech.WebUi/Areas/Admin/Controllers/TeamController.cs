using AiTech.WebUi.DTOs.TeamDtos;
using AiTech.WebUi.Services.TeamServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController(ITeamService _teamService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _teamService.GetAllAsync();
            return View(categories);
        }

        public IActionResult CreateTeam()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam(CreateTeamDto createTeamDto)
        {
            await _teamService.CreateAsync(createTeamDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateTeam(int id)
        {
            var team = await _teamService.GetByIdAsync(id);
            return View(team);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTeam(UpdateTeamDto updateTeamDto)
        {
            await _teamService.UpdateAsync(updateTeamDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTeam(int id)
        {
            await _teamService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
