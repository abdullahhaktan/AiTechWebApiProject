using AiTech.WebUi.DTOs.AboutDtos;
using AiTech.WebUi.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController(IAboutService _aboutService) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _aboutService.GetByIdAsync(1);
            return View(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UpdateAboutDto updateAboutDto)
        {
            await _aboutService.UpdateAsync(updateAboutDto);
            return RedirectToAction("Index");
        }

    }
}
